using Microsoft.AspNetCore.Mvc;

namespace BookShopByGulzar.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
