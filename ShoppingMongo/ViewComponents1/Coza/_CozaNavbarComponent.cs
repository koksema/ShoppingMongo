using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents1.Coza
{
	public class _CozaNavbarComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
