using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingMongo.Dtos.CategoryDtos;
using ShoppingMongo.Dtos.ProductDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Models;
using ShoppingMongo.Services.CategoryServices;
using ShoppingMongo.Services.ProductImageServices;
using ShoppingMongo.Services.ProductServices;

namespace ShoppingMongo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductImageService _productImageService;
        public ProductController(IProductService productService, ICategoryService categoryService, IProductImageService productImageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productImageService = productImageService;
        }


        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);

        }
        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var ktgr=await _categoryService.GetAllCategoryAsync();
            ViewBag.v = ktgr.Select(s => new SelectListItem
            {
                Text = s.CategoryName,
                Value = s.CategoryId
            }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            createProductDto.Status = true;
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var ktgr = await _categoryService.GetAllCategoryAsync();
            ViewBag.v = ktgr.Select(s => new SelectListItem
            {
                Text = s.CategoryName,
                Value = s.CategoryId
            }).ToList();

            var value = await _productService.GetProductByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            updateProductDto.Status=true;
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }
        public async Task<IActionResult> ProductDetail(string id)
        {
            var product=await _productService.GetProductByIdAsync(id);
            var img = await _productImageService.GetProductImageByProductIdAsync(id);

            var viewModel = new ProductDetailViewModel
            {
                Product = product,
                Images = img
            };

            return View(viewModel);
        }
       
    }
}
