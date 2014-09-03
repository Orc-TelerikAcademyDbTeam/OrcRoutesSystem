namespace RoutesSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    using RoutesSystem.Model.MongoDBModels;
    using RoutesSystem.Model.SQLServerModels;

    public class MongoVehicle
    {
        public MongoVehicle()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
            this.VehicleRoutes = new HashSet<MongoRoute>();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int VehicleId { get; set; }

        public virtual MongoDriver Driver { get; set; }

        public virtual MongoVehicleType VehicleType { get; set; }
         

        public virtual MongoManufacturer Manufacturer { get; set; }

        public virtual MongoModel Model { get; set; }

        public DateTime YearOfManifacturer { get; set; }

        public MongoFuelType FuelType { get; set; }

        public virtual ICollection<MongoRoute> VehicleRoutes { get; set; }
    }
}