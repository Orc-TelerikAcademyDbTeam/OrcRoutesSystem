namespace RoutesSystem.Model.MongoDBModels
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoFuelInfo
    {
        public MongoFuelInfo()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FuelId { get; set; }

        public string VehicleId { get; set; }

        public decimal Price { get; set; }

        public decimal Spent { get; set; }

        public decimal Total { get; set; }
    }
}
