using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents1.Admin
{
    public class _AdminScriptComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
