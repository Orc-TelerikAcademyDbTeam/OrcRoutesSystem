namespace Reports.ArchiveReports
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    using Reports.Contracts;

    public class ReportsArchive : IEnumerable<ArchiveReport>, IDisposable
    {
        private string reportsArchivePath;
        private IArchivator archivator;
        private string temporaryPath;
        private HashSet<string> reportsExtenstions;
        private IList<ArchiveReport> reports;

        /// <summary>
        /// Prepares reports for usage. Can be iterated.
        /// </summary>
        /// <param name="pathToArchive">Full or relative filePath to the archive file</param>
        /// <param name="reportsExtensions">Allowed report files extensions</param>
        public ReportsArchive(string pathToArchive, HashSet<string> reportsExtensions)
            : this(pathToArchive, reportsExtensions, new ZipArchivator())
        {
        }

        public ReportsArchive(string pathToArchive, HashSet<string> reportsExtensions, IArchivator archivator)
        {
            this.ReportsPath = pathToArchive;
            this.ReportsExtensions = reportsExtensions;
            this.Archivator = archivator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<ArchiveReport> GetEnumerator()
        {
            foreach (var report in this.Reports)
            {
                if (report == null)
                {
                    break;
                }

                yield return report;
            }
        }

        public string ReportsPath
        {
            get
            {
                return this.reportsArchivePath;
            }

            private set
            {
                this.reportsArchivePath = value;
            }
        }

        public HashSet<string> ReportsExtensions
        {
            get
            {
                return this.reportsExtenstions;
            }

            set
            {
                this.reportsExtenstions = value;
            }
        }

        public void Dispose()
        {
            Directory.Delete(this.temporaryPath, true);
        }

        public IList<ArchiveReport> Reports
        {
            get
            {
                if (this.reports == null)
                {
                    this.reports = new List<ArchiveReport>();
                    this.LoadReports();
                }

                return this.reports;
            }
            private set
            {
                this.reports = value;
            }
        }

        private IArchivator Archivator
        {
            get
            {
                return this.archivator;
            }

            set
            {
                this.archivator = value;
            }
        }

        private void LoadReports()
        {
            this.temporaryPath = this.GetTemporaryDirectoryPath();
            this.Archivator.ExtractToDirectory(this.reportsArchivePath, this.temporaryPath, true);
            this.AddReportsFromDirectory(this.temporaryPath);
        }

        private void AddReportsFromDirectory(string dirPath)
        {
            try
            {
                foreach (string directory in Directory.GetDirectories(dirPath))
                {
                    foreach (string file in Directory.GetFiles(directory))
                    {
                        var fileExtension = Path.GetExtension(file);
                        if (this.ReportsExtensions.Contains(fileExtension))
                        {
                            var fileName = Path.GetFileNameWithoutExtension(file);
                            var filePath = Path.GetFullPath(file);
                            var parentDirectory = Directory.GetParent(filePath).Name;
                            var report = new ArchiveReport()
                            {
                                FileExtension = fileExtension,
                                FileName = fileName,
                                FilePath = filePath,
                                DirectoryName = parentDirectory
                            };

                            this.Reports.Add(report);
                        }
                        else
                        {
                            File.Delete(file);
                        }
                    }

                    this.AddReportsFromDirectory(directory);
                }
            }
            catch (IOException ex)
            {
                throw new IOException("Some reports are not accessible!");
            }
        }

        private string GetTemporaryDirectoryPath()
        {
            string path = Path.GetRandomFileName();
            Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));
            return path;
        }
    }
}
