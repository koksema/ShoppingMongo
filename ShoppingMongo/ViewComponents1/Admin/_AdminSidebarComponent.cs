using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents1.Admin
{
    public class _AdminSidebarComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
