namespace Mongo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MongoDB.Bson;
    using MongoDB.Driver;

    using RoutesSystem.Data;
    using RoutesSystem.Model;
    using RoutesSystem.Model.MongoDBModels;
    using RoutesSystem.Model.SQLServerModels;

    public static class MongoWorker
    {
        private static MongoData data=new MongoData();

        private static void Populate()
        {
            if (!data.Manufacturers.All().Any())
            {
                data.Manufacturers.Insert(new MongoManufacturer()
                                              {
                                                  Name = "Toyota"
                                              });
                data.Manufacturers.Insert(new MongoManufacturer()
                {
                    Name = "BMW"
                });

                data.Manufacturers.Insert(new MongoManufacturer()
                {
                    Name = "Audi"
                });
            }

            if (!data.Towns.All().Any())
            {
                data.Towns.Insert(new MongoTown()
                                      {
                                          Name = "Vraca"
                                      });
                data.Towns.Insert(new MongoTown()
                {
                    Name = "Maluk Porovec"
                });

                data.Towns.Insert(new MongoTown()
                {
                    Name = "Burgas"
                });
            }

            if (!data.VehicleTypes.All().Any())
            {
                data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Sedan" });
                data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Coupe" });
                data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Limousine" });
            }
            
        }

        public static IQueryable<MongoTown> GetAllTowns()
        {
            Populate();
            return data.Towns.All();
        }

        public static IQueryable<MongoManufacturer> GetAllManufacturers()
        {
            Populate();
            return data.Manufacturers.All();
        }

        public static IQueryable<MongoVehicleType> GetAllVehicleTypes()
        {
            Populate();
            return data.VehicleTypes.All();
        } 
    }
}