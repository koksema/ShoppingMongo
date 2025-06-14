using ShoppingMongo.Dtos.ProductImageDtos;

namespace ShoppingMongo.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImageAsync(string id);
        Task<GetProductImageDto> GetProductImageByIdAsync(string id);
		Task<List<GetProductImageDto>> GetProductImageByProductIdAsync(string id);
	}
}
