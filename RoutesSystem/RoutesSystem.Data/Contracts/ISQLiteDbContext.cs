using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Data.Contracts
{
    using System.Data.Entity;

    using RoutesSystem.Model;

    interface ISQLiteDbContext:IDatabaseContext
    {
        IDbSet<DriverInfo> DriversInfo { get; set; }

        IDbSet<FuelType> FuelTypes { get; set; }

        IDbSet<Model> Models { get; set; }

        IDbSet<Manufacturer> Manufacturers { get; set; }

        IDbSet<VehicleType> VehicleTypes { get; set; }

        IDbSet<Vehicle> Vehicles { get; set; }

        IDbSet<Driver> Drivers { get; set; }

        IDbSet<Town> Towns { get; set; }

        IDbSet<Route> Routes { get; set; }

        IDbSet<VehicleRoute> VehicleRoute { get; set; }

        IDbSet<FuelInfo> FuelInfo { get; set; }

        int SaveChanges();
    }
}
