namespace Reports.ReportWriters
{
    using System.Collections.Generic;

    using MySQL;
    using Reports.ReportTypes;
    using RoutesSystem.Model.SQLiteModels;
    using SQLite;

    public class ExcelReportWriter
    {
        public void CreateReport(string filePath = null, string fileName = null)
        {
            IList<DriverInfo> sqliteDriversData = SQLiteWorker.GetDriverRouteData();
            IList<VehicleInformation> mysqlVehiclesData = EntryPoint.GetAllVehicleInformation();
            var averageSalaryReport = ExcelReport.GenerateAverageSalaryReport(sqliteDriversData);
            var averageTravelledDistanceByVehicle = ExcelReport.GenerateAverageTravelledDistanceByVehicle(sqliteDriversData, mysqlVehiclesData);
            var excelGenerator = new ExcelGenerator(filePath, fileName);
            excelGenerator.Generate(averageSalaryReport, averageTravelledDistanceByVehicle);
        }
    }
}
