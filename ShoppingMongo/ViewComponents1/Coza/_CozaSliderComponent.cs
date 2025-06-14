using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Services.SliderServices;

namespace ShoppingMongo.ViewComponents1.Coza
{
	public class _CozaSliderComponent:ViewComponent
	{
		private readonly ISliderService _sliderService;

		public _CozaSliderComponent(ISliderService sliderService)
		{
			_sliderService = sliderService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _sliderService.GetAllSliderAsync();
			return View(values);
		}
	}
}
