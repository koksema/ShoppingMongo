using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Services.CategoryServices;



namespace ShoppingMongo.ViewComponents1.Coza
{
	public class _CozaCategoryComponent:ViewComponent
	{
		private readonly ICategoryService _categoryService;

		public _CozaCategoryComponent(ICategoryService categoryService)
		{
			_categoryService = categoryService;
        }
		
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values=await _categoryService.GetAllCategoryAsync();
			return View(values);
		}
		
	}
}
