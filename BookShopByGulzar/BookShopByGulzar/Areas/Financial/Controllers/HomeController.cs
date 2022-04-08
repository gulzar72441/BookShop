using Microsoft.AspNetCore.Mvc;

namespace BookShopByGulzar.Areas.Financial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
