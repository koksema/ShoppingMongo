using ShoppingMongo.Dtos.CategoryDtos;
using ShoppingMongo.Dtos.ProductDtos;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Models
{
	public class ProductViewModel
	{
        public List<ResultProductDto> Products { get; set; }
        public List<ResultCategoryDto> Categories { get; set; }
    }
}

