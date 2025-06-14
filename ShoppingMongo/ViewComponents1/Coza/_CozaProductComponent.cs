using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Models;
using ShoppingMongo.Services.ProductServices;
using ShoppingMongo.Services.CategoryServices;

namespace ShoppingMongo.ViewComponents1.Coza
{
	public class _CozaProductComponent:ViewComponent
	{
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;

        public _CozaProductComponent(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new ProductViewModel
            {
                Products = await _productService.GetAllProductAsync(),
                Categories=await _categoryService.GetAllCategoryAsync()
            };


            return View(model);
        }
    }
}
