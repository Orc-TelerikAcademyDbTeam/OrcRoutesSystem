namespace SQLServer
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Reports.ArchiveReports;
    using Reports.ReportReaders;

    using RoutesSystem.Data;
    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Model;
    using RoutesSystem.Model.SQLServerModels;

    public static class SQLServerWorker
    {
        private static RouteSystemData data=new RouteSystemData();

        public static void ImportExcellData()
        {
            var reports = ExcellReportReader.ReadFromFile("..//..//..//ZipArchives/Fuels-Reports.zip");
                foreach (var fuelInfo in reports)
                {
                    var fuelInfoModel = new FuelInfo
                                            {
                                                Price = fuelInfo.Price,
                                                VehicleId = fuelInfo.VehicleId,
                                                Spent = fuelInfo.Spent,
                                                Total = fuelInfo.Total,
                                                FuelId = fuelInfo.FuelId
                                            };
                    data.FuelInfo.Add(fuelInfoModel);
                }
                data.FuelInfo.SaveChanges();
                

        }
    }
}
