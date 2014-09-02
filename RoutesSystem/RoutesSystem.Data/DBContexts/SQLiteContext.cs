namespace RoutesSystem.Data.DBContexts
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.Migrations;
    using RoutesSystem.Model;
    using System.Data.SQLite;
    //using System.Data.SQLite.Linq;

    public class SQLiteContext : DbContext, ISQLiteDbContext
    {
        public SQLiteContext()
            : base("SQLiteDriversInfo")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SQLiteContext>());
        }
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public IDbSet<DriverInfo> DriversInfo { get; set; }

        public IDbSet<FuelType> FuelTypes { get; set; }

        public IDbSet<Model> Models { get; set; }

        public IDbSet<Manufacturer> Manufacturers { get; set; }

        public IDbSet<VehicleType> VehicleTypes { get; set; }

        public IDbSet<Vehicle> Vehicles { get; set; }

        public IDbSet<Driver> Drivers { get; set; }

        public IDbSet<Town> Towns { get; set; }

        public IDbSet<Route> Routes { get; set; }

        public IDbSet<VehicleRoute> VehicleRoute { get; set; }

        public IDbSet<FuelInfo> FuelInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
