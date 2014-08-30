namespace RoutesSystem.Core
{
    using System;
    using RoutesSystem.Core.Reports;

    public static class RoutesSystemEngine
    {
        public static void ExportReport(ExportFileType fileType, ReportType reportType)
        {
            IReportFileType reportFileType = ExportFileTypeFactory.CreateFileType(fileType);
            var reportGenerator = new ReportGenerator(reportFileType);
            reportGenerator.Generate(reportType);
        }

        public static void LoadData()
        {
            throw new NotImplementedException();
        }
    }
}