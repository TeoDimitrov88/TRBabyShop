using Microsoft.AspNetCore.Mvc;

namespace TRBabyShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
