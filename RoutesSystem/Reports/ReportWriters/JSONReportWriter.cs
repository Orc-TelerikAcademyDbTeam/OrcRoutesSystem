namespace Reports.ReportWriters
{
    using Reports.ReportTypes;

    public class JSONReportWriter
    {
        public void CreateReport(string filePath = null, string fileName = null)
        {
            var report = new JSONReport();
            var reportData = report.GetVehicleInformation();

            var JSONGenerator = new JSONGenerator(filePath, fileName);
            JSONGenerator.Generate(reportData);
        }
    }
}
