namespace TestingProject
{
    using System;
    using System.Globalization;
    using System.Threading;

    using Reports.ReportWriters;

    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Model;
    using RoutesSystem.Data.Repositories;

    using SQLite;

    using SQLServer;
    using MySQL;
    using Mongo;
    using RoutesSystem.Data;

    internal class Program
    {
        private static void Main(string[] args)
        {

            //Repository pattern
            //var data = new RouteSystemData();

            //var jsonGen = new JSONReportWriter();
            //jsonGen.CreateReport();



            SQLServerWorker.ImportMongoDBData();
            SQLServerWorker.ImportExcellData("..//..//..//ZipArchives/Fuels-Reports.zip");

            //var pdfGen = new PdfReportWriter();
            //pdfGen.CreateReport();
            //foreach (var driver in data.Drivers.All())
            //{
            //    Console.WriteLine(driver.FirstName);
            //}

            //var db = new SQLServerContext();
            //var driversDB = new GenericRepository<Driver>(db);
            //foreach (var driver in driversDB.All())
            //{
            //    System.Console.WriteLine(driver.FirstName);
            //}


            //SQLServerWorker.ImportExcellData();
            //var XmlGen = new XmlReportWriter();
            //XmlGen.CreateReport();

            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            //var mongo = new MongoWorker();
            //mongo.Test();

            //SQLServerWorker.ImportExcellData();
            //var pdfGen = new PdfReportWriter();
            //pdfGen.CreateReport();
            ////SQLServerWorker.ImportExcellData();
            //var pdfGen = new PdfReportWriter();
            //pdfGen.CreateReport();

            //var c = new SQLiteContext();
            //c.DriversInfo.Add(new DriverInfo { StartTown = "Vraca", EndTown = "Kaspichan" });
            //c.SaveChanges();

           

            //SQLServerWorker.ImportExcellData();
            //var XmlGen = new XmlReportWriter();
            //XmlGen.CreateReport();

            //EntryPoint.Start();
            //EntryPoint.InsertRow(10, "Car", "Opel", "Fiesta", "Gas", "Pesho");

            //var c = new SQLiteContext();
            //c.DriversInfo.Add(new DriverInfo { StartTown = "Vraca", EndTown = "Kaspichan" });
            //c.SaveChanges();
            //EntryPoint.Start();

            //var c = new SQLiteContext();
            //c.DriversInfo.Add(new DriverInfo { StartTown = "Vraca", EndTown = "Kaspichan" });
            //c.SaveChanges();

            //var result = SQLiteWorker.GetData();

            //var xmlDoc = new XmlReportReader<CarTechnicalExpensesReport>("Sample-Vendors-Expenses.xml");
            //var technicalReport = xmlDoc.ReadDocument("Reports.ReportModels");
            //foreach (var entry in technicalReport)
            //{
            //    Console.WriteLine(entry.RegistrationIdentifier);
            //}
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