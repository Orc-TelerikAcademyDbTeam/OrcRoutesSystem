namespace RoutesSystem.Model.MongoDBModels
{
    using System;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoExpense
    {
        public MongoExpense()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Cost { get; set; }
    }
}
