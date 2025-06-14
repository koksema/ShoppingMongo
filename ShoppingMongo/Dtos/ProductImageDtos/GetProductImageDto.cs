using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingMongo.Dtos.ProductImageDtos
{
    public class GetProductImageDto
    {
        public string ProductImageId { get; set; }
        public string ProductId { get; set; }
        public string ProductImageUrl { get; set; }
		
	}
}
