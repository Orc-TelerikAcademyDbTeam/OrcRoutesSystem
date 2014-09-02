namespace Reports.ReportWriters
{
    using Reports.ReportTypes;

    public class PdfReportWriter
    {
        public void CreateReport()
        {
            var report = new PdfReport();
            var reportData = report.GetVisitedRoutes();

            var pdfGenerator = new PdfGenerator();
            pdfGenerator.Generate(reportData);
        }
    }
}