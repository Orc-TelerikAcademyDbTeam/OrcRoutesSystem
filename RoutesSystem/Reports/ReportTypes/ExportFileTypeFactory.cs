namespace RoutesSystem.Core.Reports
{
    using System;

    using global::Reports.ReportWriters;

    public static class ExportFileTypeFactory
    {
        public static IReportFileType CreateFileType(ExportFileType fileType)
        {
            IReportFileType reportFileType;

            switch (fileType)
            {
                case ExportFileType.Excel:
                    reportFileType = new ExcelReport();
                    break;
                case ExportFileType.JSON:
                    reportFileType = new JSONReport();
                    break;
                case ExportFileType.PDF:
                    reportFileType = new PDFReport();
                    break;
                case ExportFileType.XML:
                    reportFileType = new XmlReportWriter("a");
                    break;
                default:
                    throw new ArgumentException("Wrong file type");
            }

            return reportFileType;
        }
    }
}