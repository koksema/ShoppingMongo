using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingMongo.Dtos.ProductDtos;
using ShoppingMongo.Dtos.ProductImageDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Services.CategoryServices;
using ShoppingMongo.Services.ProductImageServices;
using ShoppingMongo.Services.ProductServices;


namespace ShoppingMongo.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;
        private readonly IProductService _productService;
        
        public ProductImageController(IProductImageService productImageService, IProductService productService)
        {
            _productImageService = productImageService;
            _productService = productService;

        }

        public async Task<IActionResult> ProductImageList()
        {
            var img=await _productImageService.GetAllProductImageAsync();
            var values = await _productService.GetAllProductAsync();
			


			var productDict = values.ToDictionary(x => x.ProductId, x => x.ProductName);

			

			return View(img);
		}
        [HttpGet]
        public async Task<IActionResult> CreateProductImage()
        {
            var ktgr = await _productService.GetAllProductAsync();
            ViewBag.v = ktgr.Select(s => new SelectListItem
            {
                Text = s.ProductName,
                Value = s.ProductId
            }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return RedirectToAction("ProductImageList");
        }
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return RedirectToAction("ProductImageList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProductImage(string id)
        {
            var ktgr = await _productService.GetAllProductAsync();
            ViewBag.v = ktgr.Select(s => new SelectListItem
            {
                Text = s.ProductName,
                Value = s.ProductId
            });

            var value = await _productImageService.GetProductImageByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {

            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return RedirectToAction("ProductImageList");
        }
    }
}
