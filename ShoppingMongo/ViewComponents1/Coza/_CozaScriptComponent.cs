using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents1.Coza
{
	public class _CozaScriptComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
