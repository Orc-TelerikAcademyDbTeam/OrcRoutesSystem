namespace RoutesSystem.Data.DBContexts
{
    using MongoDB.Driver;

    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Model;
    using RoutesSystem.Model.MongoDBModels;
    using RoutesSystem.Model.SQLServerModels;

    internal class MongoDBContext : IMongoDBContext
    {
        private MongoClient client;

        private MongoDatabase database;

        public MongoDBContext(string url, string database)
        {
            this.client=new MongoClient(url);
            this.database = client.GetServer().GetDatabase(database);
        }

        public MongoDBContext()
            : this("mongodb://localhost", "RoutesSystem")
        {
            
        }

        public MongoCollection Set<T>(string name) where T : class
        {
            return this.database.GetCollection<T>(name);
        }

        public MongoCollection Set<T>() where T : class
        {
            return this.Set<T>((typeof(T)).Name);
        }

        public MongoCollection<MongoDriver> Drivers { get; set; }

        public MongoCollection<MongoFuelInfo> FuelInfo { get; set; }

        public MongoCollection<MongoFuelType> FuelTypes { get; set; }

        public MongoCollection<MongoManufacturer> Manufacturers { get; set; }

        public MongoCollection<MongoModel> Models { get; set; }

        public MongoCollection<MongoRoute> Routes { get; set; }

        public MongoCollection<MongoTown> Towns { get; set; }

        public MongoCollection<MongoVehicle> Vehicles { get; set; }

        public MongoCollection<MongoVehicleType> VehicleTypes { get; set; }

        public MongoCollection<MongoCarEntry> VehicleExpensesInfo { get; set; }

        public MongoCollection<MongoExpense> VehicleExpenses { get; set; }
    }
}