﻿namespace RoutesSystem.Model.MongoDBModels
{
    using System.Collections.Generic;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoCarEntry
    {
        public MongoCarEntry()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int VehicleId { get; set; }

        public ICollection<MongoExpense> Expenses { get; set; } 
    }
}
