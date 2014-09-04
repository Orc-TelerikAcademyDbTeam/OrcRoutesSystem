namespace RoutesSystem.Model.MongoDBModels
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    using RoutesSystem.Model.SQLServerModels;

    public class MongoRoute
    {
        public MongoRoute()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int RouteId { get; set; }

        public virtual MongoTown StartTown { get; set; }

        public virtual MongoTown EndTown { get; set; }

        public float Distance { get; set; }
    }
}