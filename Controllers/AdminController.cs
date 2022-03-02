using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
