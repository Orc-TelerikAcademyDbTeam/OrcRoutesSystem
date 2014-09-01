namespace SQLServer
{
    using System;
    using System.Collections.Generic;

    using Reports.ArchiveReports;

    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Model;
    public static class SQLServerWorker
    {
        private static SQLServerContext context=new SQLServerContext();

        public static void ImportExcellData()
        {
            var archiveReport = new ReportsArchive(
                "..//..//..//ZipArchives/Sample-Sales-Reports.zip",
                new HashSet<string>() { ".xls" });

            using (archiveReport)
            {
                foreach (var report in archiveReport)
                {
                    Console.WriteLine("{0} => {1}  {2}", report.DirectoryName, report.FileName, report.FileExtension);
                }
            }
        }
    }
}
