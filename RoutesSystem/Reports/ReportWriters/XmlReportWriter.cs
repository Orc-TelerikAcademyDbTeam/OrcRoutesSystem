namespace Reports.ReportWriters
{
    using Reports.ReportTypes;

    public class XmlReportWriter
    {
        public void CreateReport(string filePath = null, string fileName = null)
        {
            var report = new XmlReport();
            var inputData = report.FuelSpent();

            var pdfGenerator = new XmlGenerator(filePath, fileName);
            pdfGenerator.Generate(inputData);
        }
    }
}