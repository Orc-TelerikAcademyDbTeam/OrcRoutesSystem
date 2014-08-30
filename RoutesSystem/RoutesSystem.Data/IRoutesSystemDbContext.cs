namespace RoutesSystem.Data
{
    using RoutesSystem.Model;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IRoutesSystemDbContext
    {
        IDbSet<FuelType> FuelTypes { get; set; }

        IDbSet<Model> Models { get; set; }

        IDbSet<Manufacturer> Manufacturers { get; set; }

        IDbSet<VehicleType> VehicleTypes { get; set; }

        IDbSet<Vehicle> Vehicles { get; set; }

        IDbSet<Driver> Drivers { get; set; }

        IDbSet<Town> Towns { get; set; }

        IDbSet<Route> Routes { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();
    }
}
