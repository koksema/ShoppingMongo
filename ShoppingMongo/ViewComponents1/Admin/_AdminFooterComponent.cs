using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents1.Admin
{
    public class _AdminFooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
