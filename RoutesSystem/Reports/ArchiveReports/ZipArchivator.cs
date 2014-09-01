namespace Reports.ArchiveReports
{
    using System.IO;
    using System.IO.Compression;

    using Reports.Contracts;

    public class ZipArchivator:IArchivator
    {
        public void Archive(string sourcePath, string destinationPath, string archiveFileName)
        {
            var archiveFullPath = destinationPath + archiveFileName + ".zip";
            bool archiveFileExists = File.Exists(archiveFullPath);
            if (archiveFileExists)
            {
                string exceptionMessage = string.Format("Archive file already exists in {0}", archiveFullPath);
                throw new IOException(exceptionMessage);
            }

            FileAttributes sourceAttributes = File.GetAttributes(sourcePath);

            // It`s directory
            if ((sourceAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                ZipFile.CreateFromDirectory(sourcePath, archiveFullPath, CompressionLevel.Fastest, true);
            }
            // It`s file
            else
            {
                using (FileStream zipToOpen = new FileStream(archiveFullPath, FileMode.Create))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                    {
                        ZipArchiveEntry readmeEntry = archive.CreateEntry(sourcePath);
                    }
                }
            }
        }

        public void ExtractToDirectory(string pathToArchive, string outputPath, bool createDirectoryIfNotExists = true)
        {
            bool archiveFileExists = File.Exists(pathToArchive);
            if (!archiveFileExists)
            {
                string fileNotFoundExceptionMessage = string.Format("Archive file not found in {0}", pathToArchive);
                throw new IOException(fileNotFoundExceptionMessage);
            }

            if (!Directory.Exists(outputPath))
            {
                if (!createDirectoryIfNotExists)
                {
                    var directoryNotFoundExceptionMessage = string.Format("Destination directory not found {0}", outputPath);
                    throw new IOException(directoryNotFoundExceptionMessage);
                }

                Directory.CreateDirectory(outputPath);
            }

            ZipFile.ExtractToDirectory(pathToArchive, outputPath);
        }
    }
}
