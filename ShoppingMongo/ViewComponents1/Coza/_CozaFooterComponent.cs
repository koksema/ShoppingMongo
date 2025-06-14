using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Models;

namespace ShoppingMongo.ViewComponents1.Coza
{
	public class _CozaFooterComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(new AdminMailViewModel());
		}
	}
}
