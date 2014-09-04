namespace RoutesSystem.Data.Contracts
{
    using MongoDB.Driver;

    using RoutesSystem.Model;
    using RoutesSystem.Model.MongoDBModels;
    using RoutesSystem.Model.SQLServerModels;

    public interface IMongoDBContext
    {
        MongoCollection<MongoDriver> Drivers { get; set; }

        MongoCollection<MongoFuelInfo> FuelInfo { get; set; }

        MongoCollection<MongoFuelType> FuelTypes { get; set; }

        MongoCollection<MongoManufacturer> Manufacturers { get; set; }

        MongoCollection<MongoModel> Models { get; set; }

        MongoCollection<MongoRoute> Routes { get; set; }

        MongoCollection<MongoTown> Towns { get; set; }

        MongoCollection<MongoVehicle> Vehicles { get; set; }

        MongoCollection<MongoVehicleType> VehicleTypes { get; set; }

        MongoCollection Set<T>(string setName) where T : class;

        MongoCollection Set<T>() where T : class;
    }
}
