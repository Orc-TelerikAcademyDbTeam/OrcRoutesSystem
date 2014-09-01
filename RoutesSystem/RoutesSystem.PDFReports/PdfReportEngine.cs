namespace RoutesSystem.PDFReports
{
    using System;

    public class PdfReportEngine
    {
        public void CreateReport()
        {
            var report = new Report();
            var reportData = report.GetVisitedRoutes();

            var pdfGenerator = new PdfGenerator();
            pdfGenerator.Generate(reportData);
        }
    }
}