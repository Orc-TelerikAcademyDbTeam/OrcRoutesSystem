namespace Reports.ReportWriters
{
    using MySQL;
    using RoutesSystem.Model.SQLiteModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SQLite;
    using Reports.ReportTypes;

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
