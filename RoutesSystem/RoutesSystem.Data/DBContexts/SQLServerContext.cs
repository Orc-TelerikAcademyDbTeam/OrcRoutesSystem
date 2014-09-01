namespace RoutesSystem.Data.DBContexts
{
    using System.Data.Entity;

    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.Migrations;
    using RoutesSystem.Model;

    public class SQLServerContext : DbContext, IRoutesSystemDbContext
    {
        public SQLServerContext()
            : base("RoutesSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SQLServerContext, SQLServerConfiguration>());
        }

        public IDbSet<FuelType> FuelTypes { get; set; }

        public IDbSet<Model> Models { get; set; }

        public IDbSet<Manufacturer> Manufacturers { get; set; }

        public IDbSet<VehicleType> VehicleTypes { get; set; }

        public IDbSet<Vehicle> Vehicles { get; set; }

        public IDbSet<Driver> Drivers { get; set; }

        public IDbSet<Town> Towns { get; set; }

        public IDbSet<Route> Routes { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Route>()
                .HasRequired(t => t.StartTown)
                .WithMany(t => t.StartRoutes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Route>()
                .HasRequired(t => t.EndTown)
                .WithMany(t => t.EndRoutes)
                .WillCascadeOnDelete(false);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
