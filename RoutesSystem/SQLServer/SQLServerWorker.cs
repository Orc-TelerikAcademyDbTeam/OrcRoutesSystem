namespace SQLServer
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Reports.ArchiveReports;
    using Reports.ReportReaders;

    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Model;
    public static class SQLServerWorker
    {
        private static SQLServerContext context=new SQLServerContext();

        public static void ImportExcellData()
        {
            var reports = ExcellReportReader.ReadFromFile("..//..//..//ZipArchives/Fuels-Reports.zip");
            using (context)
            {
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
                    context.FuelInfo.Add(fuelInfoModel);
                }
                context.SaveChanges();
                
            }

        }
    }
}
