namespace RoutesSystem.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using RoutesSystem.Model;

    public interface IRoutesSystemDbContext : IDatabaseContext
    {
        IDbSet<FuelType> FuelTypes { get; set; }

        IDbSet<Model> Models { get; set; }

        IDbSet<Manufacturer> Manufacturers { get; set; }

        IDbSet<VehicleType> VehicleTypes { get; set; }

        IDbSet<Vehicle> Vehicles { get; set; }

        IDbSet<Driver> Drivers { get; set; }

        IDbSet<Town> Towns { get; set; }

        IDbSet<Route> Routes { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
