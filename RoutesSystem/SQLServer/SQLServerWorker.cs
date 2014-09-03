namespace SQLServer
{
    using System.Linq;

    using Mongo;

    using Reports.ReportReaders;

    using RoutesSystem.Data;
    using RoutesSystem.Model.SQLServerModels;

    public static class SQLServerWorker
    {
        private static RouteSystemData data = new RouteSystemData();

        public static void ImportMongoDBData()
        {
            var mongoData = new MongoWorker();

            var allManufacturers = mongoData.GetAllManufacturers();

            foreach (var manufacturer in allManufacturers)
            {
                data.Manufacturers.Add(new Manufacturer() { Name = manufacturer.Name });
                data.Manufacturers.SaveChanges();
            }

            var allTowns = mongoData.GetAllTowns();
            foreach (var town in allTowns)
            {
                data.Towns.Add(new Town() { Name = town.Name });
                data.Towns.SaveChanges();
            }

            var allVehicleTypes = mongoData.GetAllVehicleTypes();
            foreach (var type in allVehicleTypes)
            {
                data.VehicleTypes.Add(new VehicleType() { Name = type.Name, });
                data.VehicleTypes.SaveChanges();
            }

            var allFuelTypes = mongoData.GetAllFuelTypes();
            foreach (var fuel in allFuelTypes)
            {
                data.Fueltypes.Add(new FuelType() { Name = fuel.Name });
                data.Fueltypes.SaveChanges();
            }

            var allModels = mongoData.GetAllModels();
            foreach (var model in allModels)
            {
                data.Models.Add(new Model()
                                    {
                                        FuelConsumption = model.FuelConsumption,
                                        Name = model.Name,
                                        NumberOfWheels = model.NumberOfWheels,
                                    });
                data.Models.SaveChanges();
            }

            var allVehicles = mongoData.GetAllVehicles();
            foreach (var vehicle in allVehicles)
            {
                int vehicleTypeId =
                    data.VehicleTypes.SearchFor(x => x.Name == vehicle.VehicleType.Name).Select(x => x.Id).First();
                int manufacturerId =
                    data.Manufacturers.SearchFor(x => x.Name == vehicle.Manufacturer.Name).Select(x => x.Id).First();
                int modelId = data.Models.SearchFor(x => x.Name == vehicle.Model.Name).Select(x => x.Id).First();

                int fuelTypeId = data.Fueltypes.SearchFor(x => x.Name == vehicle.FuelType.Name).Select(x => x.Id).First();

                data.Vehicles.Add(
                    new Vehicle()
                        {
                            VehicleTypeId = vehicleTypeId,
                            ManufacturerId = manufacturerId,
                            ModelId = modelId,
                            YearOfManifacturer = vehicle.YearOfManifacturer,
                            FuelTypeId = fuelTypeId
                        });
                data.Vehicles.SaveChanges();
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