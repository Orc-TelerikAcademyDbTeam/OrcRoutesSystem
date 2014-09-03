namespace RoutesSystem.Model.MongoDBModels
{
    using System;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoVehicleRoute
    {
        public MongoVehicleRoute()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 

        public int RouteId { get; set; }

        public int VehicleId { get; set; }

        public DateTime Date { get; set; }
    }
}
