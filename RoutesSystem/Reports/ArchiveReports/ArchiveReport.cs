namespace Reports.ArchiveReports
{
    using Reports.Contracts;

    public class ArchiveReport : IReport
    {
        public string DirectoryName { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public string FileExtension { get; set; }
    }
}
