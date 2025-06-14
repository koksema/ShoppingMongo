using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace ShoppingMongo.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? ProductImageId { get; set; }
		[MongoDB.Bson.Serialization.Attributes.BsonRepresentation(BsonType.ObjectId)]
		public string? ProductId { get; set; } // Hangi ürüne ait olduğunu belirtir
       
        public string? ProductImageUrl { get; set; }


    }
}
