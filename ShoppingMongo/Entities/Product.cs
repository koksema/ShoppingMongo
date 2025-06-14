﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingMongo.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string ProductId { get; set; }
        
        public string ProductName { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public decimal ProductPrice { get; set; }
        public bool Status { get; set; }
        public int StockCount { get; set; }
		public string ProductImage { get; set; }
        //public List<ProductImage> ProductImages { get; set; }
        public string CategoryId { get; set; }
    }
}
