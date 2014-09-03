namespace RoutesSystem.Model.MongoDBModels
{
    using System;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoVehicleRoute
    {
        public MongoVehicleRoute()
        {

        }

        [BsonRepresentation(BsonType.ObjectId)]
        public MongoRoute RouteId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public MongoVehicle VehicleId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public DateTime Date { get; set; }
    }
}
