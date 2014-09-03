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

            //Fill Manufactures
            var allManufacturers = mongoData.GetAllManufacturers();

            foreach (var manufacturer in allManufacturers)
            {
                data.Manufacturers.Add(new Manufacturer() { Name = manufacturer.Name });
                data.Manufacturers.SaveChanges();
            }

            //Fill Towns
            var allTowns = mongoData.GetAllTowns();
            foreach (var town in allTowns)
            {
                data.Towns.Add(new Town() { Name = town.Name });
                data.Towns.SaveChanges();
            }

            //Fill Vehicle Types
            var allVehicleTypes = mongoData.GetAllVehicleTypes();
            foreach (var type in allVehicleTypes)
            {
                data.VehicleTypes.Add(new VehicleType() { Name = type.Name, });
                data.VehicleTypes.SaveChanges();
            }

            //Fill Fuel Types
            var allFuelTypes = mongoData.GetAllFuelTypes();
            foreach (var fuel in allFuelTypes)
            {
                data.Fueltypes.Add(new FuelType() { Name = fuel.Name });
                data.Fueltypes.SaveChanges();
            }

            //Fill Models
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

            //Fill Vehicles
            var allVehicles = mongoData.GetAllVehicles();
            foreach (var vehicle in allVehicles)
            {
                int vehicleTypeId =
                    data.VehicleTypes.SearchFor(x => x.Name == vehicle.VehicleType.Name).Select(x => x.Id).First();
                int manufacturerId =
                    data.Manufacturers.SearchFor(x => x.Name == vehicle.Manufacturer.Name).Select(x => x.Id).First();
                int modelId = data.Models.SearchFor(x => x.Name == vehicle.Model.Name).Select(x => x.Id).First();

                int fuelTypeId = data.Fueltypes.SearchFor(x => x.Name == vehicle.FuelType.Name).Select(x => x.Id).First();

                var driverModel = new Driver()
                {
                    FirstName = vehicle.Driver.FirstName,
                    MiddleName = vehicle.Driver.MiddleName,
                    LastName = vehicle.Driver.LastName
                };

                var vehicleModel = new Vehicle()
                {
                    VehicleTypeId = vehicleTypeId,
                    ManufacturerId = manufacturerId,
                    ModelId = modelId,
                    YearOfManifacturer = vehicle.YearOfManifacturer,
                    FuelTypeId = fuelTypeId
                };

                data.Vehicles.Add(vehicleModel);
                data.Vehicles.SaveChanges();

                driverModel.VehicleId = vehicleModel.Id;
                data.Drivers.Add(driverModel);
                data.Drivers.SaveChanges();
            }

            //Fill Routes
            var allRoutes = mongoData.GetAllRoutes();
            foreach (var route in allRoutes)
            {
                var startTown = data.Towns.SearchFor(x => x.Name == route.StartTown.Name).FirstOrDefault().Id;
                var endTown = data.Towns.SearchFor(x => x.Name == route.EndTown.Name).FirstOrDefault().Id;

                data.Routes.Add(
                    new Route()
                    {
                        StartTownId = startTown,
                        EndTownId = endTown,
                        Distance = route.Distance,
                    });

                data.Routes.SaveChanges();
            }

            //Fill VehicleRoutes
            var allVehicleRoutes = mongoData.GetAllVehicleRoutes();
            foreach (var vehicleRoute in allVehicleRoutes)
            {
                data.VehicleRoutes.Add(
                    new VehicleRoute() 
                    {
                        RouteId = vehicleRoute.RouteId,
                        VehicleId = vehicleRoute.VehicleId,
                        Date = vehicleRoute.Date
                    });

                data.VehicleRoutes.SaveChanges();
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