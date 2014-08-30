namespace ArchiveReports.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IReport
    {
        string DirectoryName { get; set; }

        string FilePath { get; set; }

        string FileName { get; set; }
    }
}
