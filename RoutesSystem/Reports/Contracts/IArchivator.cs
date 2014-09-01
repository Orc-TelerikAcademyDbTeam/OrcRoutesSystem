namespace Reports.Contracts
{
    public interface IArchivator
    {
        void Archive(string sourcePath, string destinationPath, string archiveFileName);

        void ExtractToDirectory(string pathToArchive, string outputPath, bool createDirectoryIfNotExists);
    }
}
