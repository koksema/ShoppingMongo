using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.Controllers
{
    public class DefaulttController : Controller
    {

		//[Route("/")]
		public IActionResult Index()
        {
            return View();
        }
    }
}
