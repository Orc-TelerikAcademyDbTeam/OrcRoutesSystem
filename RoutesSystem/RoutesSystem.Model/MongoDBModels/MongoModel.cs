namespace RoutesSystem.Model.MongoDBModels
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoModel
    {
        public MongoModel()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public float FuelConsumption { get; set; }

        public int NumberOfWheels { get; set; }
    }
}
