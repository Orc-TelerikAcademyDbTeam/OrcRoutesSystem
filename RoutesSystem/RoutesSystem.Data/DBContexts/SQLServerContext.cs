namespace RoutesSystem.Data.DBContexts
{
    using System;
    using System.Data.Entity;
    using RoutesSystem.Data.Contracts;
    using RoutesSystem.Data.Migrations;
    using RoutesSystem.Model;
    using RoutesSystem.Model.SQLServerModels;

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

        public IDbSet<VehicleRoute> VehicleRoute { get; set; }

        public IDbSet<FuelInfo> FuelInfo { get; set; }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void SaveChanges()
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
