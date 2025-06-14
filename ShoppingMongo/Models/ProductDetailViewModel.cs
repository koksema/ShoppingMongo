using ShoppingMongo.Dtos.ProductDtos;
using ShoppingMongo.Dtos.ProductImageDtos;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Models
{
	public class ProductDetailViewModel
	{
        public GetProductDto Product { get; set; }
        public List<GetProductImageDto> Images { get; set; }

    }
}
