using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents1.Coza
{
	public class _CozaHeadComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
