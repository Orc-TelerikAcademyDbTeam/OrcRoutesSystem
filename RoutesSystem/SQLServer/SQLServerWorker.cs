namespace SQLServer
{
    using Mongo;

    using Reports.ReportReaders;

    using RoutesSystem.Data;
    using RoutesSystem.Model.SQLServerModels;

    public static class SQLServerWorker
    {
        private static RouteSystemData data = new RouteSystemData();

        public static void ImportMongoDBData()
        {
            var allManufacturers = MongoWorker.GetAllManufacturers();

            foreach (var manufacturer in allManufacturers)
            {
                data.Manufacturers.Add(new Manufacturer() { Name = manufacturer.Name });
                data.Manufacturers.SaveChanges();
            }

            var allTowns = MongoWorker.GetAllTowns();
            foreach (var town in allTowns)
            {
                data.Towns.Add(new Town() { Name = town.Name });
                data.Towns.SaveChanges();
            }

            var allVehicleTypes = MongoWorker.GetAllVehicleTypes();
            foreach (var type in allVehicleTypes)
            {
                data.VehicleTypes.Add(new VehicleType() { Name = type.Name, });
                data.Towns.SaveChanges();
            }
        }

        public static void ImportExcellData(string filePath)
        {
            var reports = ExcellReportReader.ReadFromFile(filePath);
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