namespace Reports.ReportWriters
{
    using Reports.ReportTypes;

    public class PdfReportWriter
    {
        public void CreateReport(string filePath = null, string fileName = null)
        {
            var report = new PdfReport();
            var reportData = report.GetVisitedRoutes();

            var pdfGenerator = new PdfGenerator(filePath, fileName);
            pdfGenerator.Generate(reportData);
        }
    }
}