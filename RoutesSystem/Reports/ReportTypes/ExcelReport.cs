namespace Reports.ReportTypes
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;

    using global::Reports.ReportModels;
    using RoutesSystem.Model.SQLiteModels;
    using MySQL;
    using System.Linq;

    internal static class ExcelReport
    {
        public static ICollection<FuelInfo> ReadFuelInfo(string filePath)
        {
            var result = new List<FuelInfo>();
            var con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + filePath + "; Extended Properties = \"Excel 12.0 Xml; HDR = YES; IMEX = 2\"");

            con.Open();
            using (con)
            {
                var dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                var sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"];
                var command = new OleDbCommand("SELECT * FROM " + "[" + sheetName + "]", con);
                var reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    if (reader[0] == DBNull.Value)
                    {
                        return result;
                    }
                    var info = new FuelInfo();
                    info.FuelId = Convert.ToInt32(reader[0]);
                    info.VehicleId = Convert.ToInt32(reader[1]);
                    info.Price = Convert.ToDecimal(reader[2]);
                    info.Spent = Convert.ToDecimal(reader[3]);
                    info.Total = Convert.ToDecimal(reader[4]);
                    result.Add(info);
                }
            }
            return result;
        }

        internal static IList<AverageDriverSalary> GenerateAverageSalaryReport(IList<DriverInfo> sqliteDriversData)
        {
            var drivers = new Dictionary<string, AverageDriverSalary>();
            foreach (var driver in sqliteDriversData)
            {
                var key = driver.DriverFirstName + " " + driver.DriverLastName;
                if (drivers.ContainsKey(key))
                {
                    drivers[key].SalariesCount++;
                    drivers[key].SalarySum += driver.DriverSalary;
                }
                else
                {
                    var newDriver = new AverageDriverSalary()
                    {
                        DriverFirstName = driver.DriverFirstName,
                        DriverLastName = driver.DriverLastName,
                        SalarySum = driver.DriverSalary,
                        SalariesCount = 1
                    };
                    drivers.Add(key, newDriver);
                }
            }

            return drivers.Select(x => x.Value).ToList();
        }

        internal static IList<AverageTravelledDistance> GenerateAverageTravelledDistanceByVehicle(IList<DriverInfo> sqliteDriversData, IList<MySQL.VehicleInformation> mysqlVehiclesData)
        {
            var travelledRoutes = new Dictionary<string, AverageTravelledDistance>();
            foreach (var vehicle in mysqlVehiclesData)
            {
                var key = vehicle.DriverFirstName + " " + vehicle.DriverLastName;
                if (!travelledRoutes.ContainsKey(key))
                {
                    var newDriver = new AverageTravelledDistance()
                    {
                        DriverFirstName = vehicle.DriverFirstName,
                        DriverLastName = vehicle.DriverLastName,
                        VehicleManufacturer = vehicle.Manufactorer,
                        VehicleModel = vehicle.VehicleModel,
                        TravelledRoutesCount = 0,
                        TravelledDistance = 0
                    };
                    travelledRoutes.Add(key, newDriver);
                }
            }

            foreach (var route in sqliteDriversData)
            {
                var key = route.DriverFirstName + " " + route.DriverLastName;
                if (travelledRoutes.ContainsKey(key))
                {
                    var vehicle = travelledRoutes[key];
                    vehicle.TravelledDistance += route.RouteDistance;
                    vehicle.TravelledRoutesCount++;
                }
            }

            return travelledRoutes.Where(x => x.Value.TravelledRoutesCount > 0).Select(x => x.Value).ToList();
        }
    }
}