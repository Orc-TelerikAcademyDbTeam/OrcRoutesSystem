namespace RouteSystem.UI
{
    using Reports.ReportWriters;

    internal static class UIEngine
    {
        internal static void CreatePDFReport(string filePathInfo)
        {
            var pdfGen = new PdfReportWriter();

            var lastIndexOfSlash = filePathInfo.LastIndexOf(@"\");
            var filePath = filePathInfo.Substring(0, lastIndexOfSlash);
            var fileName = filePathInfo.Substring(lastIndexOfSlash + 1);

            pdfGen.CreateReport(filePath, fileName);
        }

    }
}
