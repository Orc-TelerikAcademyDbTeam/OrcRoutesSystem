namespace Reports.ReportWriters
{
    using Reports.ReportTypes;

    public class JSONReportWriter
    {
        public void CreateReport()
        {
            var report = new JSONReport();
            var reportData = report.GetVehicleInformation();

            var JSONGenerator = new JSONGenerator();
            JSONGenerator.Generate(reportData);
        }
    }
}
