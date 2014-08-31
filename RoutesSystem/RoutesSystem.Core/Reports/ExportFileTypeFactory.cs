namespace RoutesSystem.Core.Reports
{
    using System;

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
                    reportFileType = new XMLReport("a");
                    break;
                default:
                    throw new ArgumentException("Wrong file type");
            }

            return reportFileType;
        }
    }
}