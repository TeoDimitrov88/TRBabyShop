using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Models;

namespace TRBabyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService _productService)
        {
           productService = _productService;
        }

        public async Task<IActionResult> Index()
        {
            var model=await productService.GetProductAsync();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}