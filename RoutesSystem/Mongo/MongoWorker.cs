namespace Mongo
{
    using System;
    using System.Collections.Generic;

    using MongoDB.Bson;
    using MongoDB.Driver;

    using RoutesSystem.Data;
    using RoutesSystem.Model;
    using RoutesSystem.Model.MongoDBModels;
    using RoutesSystem.Model.SQLServerModels;

    public static class MongoWorker
    {
        private static MongoData data=new MongoData();

        public static void AddDriver(MongoDriver driver)
        {
            
        }

        public static void Test()
        {
            data.Drivers.Insert(new MongoDriver() { FirstName = "Penio", LastName = "Peniov", MiddleName = "Penkov" });

            data.Vehicles.Insert(
                new MongoVehicle()
                    {
                        Driver =
                            new MongoDriver()
                                {
                                    FirstName = "Gancho",
                                    LastName = "Ganchev",
                                    MiddleName = "Penchev"
                                },
                        FuelType = new MongoFuelType() { Name = "Diesel" },
                        Manufacturer = new MongoManufacturer() { Name = "Toyota" },
                        Model =
                            new MongoModel()
                                {
                                    FuelConsumption = 2.7f,
                                    Name = "Avensis",
                                    NumberOfWheels = 4
                                },
                        VehicleRoutes =
                            new List<MongoRoute>()
                                {
                                    new MongoRoute()
                                        {
                                            Distance = 3.7f,
                                            EndTown =
                                                new MongoTown()
                                                    {
                                                        Name =
                                                            "Vraca"
                                                    },
                                            StartTown =
                                                new MongoTown()
                                                    {
                                                        Name =
                                                            "Sofia"
                                                    },
                                        },
                                },
                        YearOfManifacturer = new DateTime(1993, 2, 2),
                        VehicleType = new MongoVehicleType() { Name = "Sedan" }
                    });

            data.FuelInfo.Insert(
                new MongoFuelInfo()
                    {
                        VehicleId = data.Vehicles.FindOne().Id,
                        FuelId = data.Vehicles.FindOne().FuelType.Id,
                        Price = 14.5m,
                        Spent = 10.3m,
                        Total = 30m
                    });
        }
    }
}