namespace Reports.ReportReaders
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Reports.ArchiveReports;
    using Reports.ReportModels;
    using Reports.ReportTypes;

    public static class ExcellReportReader
    {
        public static ICollection<FuelInfo> ReadFromFile(string filePath)
        {
            var result = new List<FuelInfo>();
            
            var archiveReport = new ReportsArchive(
                filePath,
                new HashSet<string>() { ".xls" });

            using (archiveReport)
            {
                foreach (var report in archiveReport)
                {
                    var entries = ExcelReport.ReadFuelInfo(report.FilePath);
                    result.AddRange(entries);
                }
            }

            return result;
        }

        private static DateTime ParseDate(string fileName)
        {
            return DateTime.Now;
        }
    }
}
