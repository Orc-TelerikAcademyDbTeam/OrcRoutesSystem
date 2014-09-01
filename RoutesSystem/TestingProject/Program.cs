namespace TestingProject
{
    using System;
    using System.Linq;

    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Core.OpenAccess;
    using RoutesSystem.Core.Reports;
    using RoutesSystem.Core.Models;

    internal class Program
    {
        private static void Main(string[] args)
        {
            EntryPoint.Start();

            var xmlDoc = new XmlReporter<CarTechnicalExpensesReport>("Report.xml");
            var technicalReport = xmlDoc.ReadDocument("RoutesSystem.Core.Models");
            foreach (var entry in technicalReport)
            {
                Console.WriteLine(entry.RegistrationIdentifier);
            }

            //var SQLServerData = new RoutesSystemDbContext();
            //SQLServerData.VehicleTypes.Add(new VehicleType { Name = "Sedan" });
            //SQLServerData.SaveChanges();

            //var manufacturer = new Manufacturer { Name = "Toyota" };

            //SQLServerData.Manufacturers.Add(manufacturer);
            //SQLServerData.SaveChanges();

            //    SQLServerData.Vehicles.Add(
            //        new Vehicle
            //            {
            //                Driver = new Driver
            //                             {
            //                                 FirstName = "Pencho", LastName = "Penchev"
            //                             },
            //                VehicleTypeId = 1,
            //                YearOfManifacturer = DateTime.Now,
            //                FuelType = new FuelType { Name = "Diesel" },
            //                ManufacturerId = 1,
            //                Model = new Model { Name = "Avensis", FuelConsumption = 5.5f, NumberOfWheels = 4 }
            //            });

            //    SQLServerData.SaveChanges();

            //var SQLiteData = new SQLiteContext();
            //SQLiteData.DriversInfo.Add(new DriverInfo { Id = 1, StartTown = "Sofiq", EndTown = "Varna" });
            //SQLiteData.SaveChanges();
            //var driverInfo = SQLiteData.DriversInfo.First();
            //var driver = SQLServerData.Drivers.First(x => x.VehicleId == driverInfo.Id);
            //Console.WriteLine(
            //    "Driver " + driver.FirstName + " went through " + driverInfo.StartTown + " - " + driverInfo.EndTown);

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