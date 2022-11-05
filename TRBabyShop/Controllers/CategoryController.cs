using Microsoft.AspNetCore.Mvc;

namespace TRBabyShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
