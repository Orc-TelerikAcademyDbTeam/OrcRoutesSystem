namespace Reports.Contracts
{
    public interface IReport
    {
        string DirectoryName { get; set; }

        string FilePath { get; set; }

        string FileName { get; set; }
    }
}
