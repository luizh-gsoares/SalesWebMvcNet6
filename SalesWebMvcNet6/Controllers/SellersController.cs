using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvcNet6.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
