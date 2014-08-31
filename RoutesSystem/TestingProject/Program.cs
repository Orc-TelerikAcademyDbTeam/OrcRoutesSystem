using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    using System.Collections.ObjectModel;

    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Model;

    class Program
    {
        static void Main(string[] args)
        {
            var SQLiteData = new SQLiteContext();
            SQLiteData.DriversInfo.Add(new DriverInfo { Id = 1, StartTown = "Sofiq", EndTown = "Varna" });
            SQLiteData.SaveChanges();
            var driverInfo = SQLiteData.DriversInfo.First();
            Console.WriteLine("Driver with id "+
                driverInfo.Id + " went through " + driverInfo.StartTown + " - "
                + driverInfo.EndTown);

            //var SQLServerData = new RoutesSystemDbContext();
            //SQLServerData.VehicleTypes.Add(new VehicleType { Name = "Sedan" });
            //SQLServerData.SaveChanges();

            //var manufacturer = new Manufacturer { Name = "Toyota" };

            //SQLServerData.Manufacturers.Add(manufacturer);
            //SQLServerData.SaveChanges();
            //SQLServerData.Vehicles.Add(
            //    new Vehicle
            //    {
            //        VehicleTypeId = 1,
            //        YearOfManifacturer = DateTime.Now,
            //        FuelType = new FuelType
            //        {
            //            Name = "Diesel"

            //        },
            //        Manufacturer = manufacturer,
            //        Model = new Model
            //        {
            //            Name = "Avensis",
            //            FuelConsumption = 5.5f,
            //            NumberOfWheels = 4
            //        }


            //    });

            //SQLServerData.SaveChanges();

            //var v = SQLServerData.Vehicles.Where(x=>x.Id>0).ToList();
            //foreach (var vehicle in v)
            //{
            //    Console.WriteLine(vehicle.Id);
            //}

            //var newDriver = new Driver { FirstName = "Pencho", LastName = "Penchev", VehicleId = SQLServerData.Vehicles.Select(x=>x.Id).First() };
            //SQLServerData.Drivers.Add(newDriver);
            //SQLServerData.SaveChanges();


            //var driver = SQLServerData.Drivers.First(x => x.VehicleId == driverInfo.Id);
            
        }
    }
}
