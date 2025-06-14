using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents1.Admin
{
    public class _AdminHeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
