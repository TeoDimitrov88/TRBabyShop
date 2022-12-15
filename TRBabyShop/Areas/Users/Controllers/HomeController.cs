using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;
using TRBabyShop.Models;
using static TRBabyShop.Infrastructure.Data.Common.Constants;

namespace TRBabyShop.Areas.Admin.Controllers
{
    [Area("Users")]
    public class HomeController : Controller
    {
        private readonly IProductService productService;
       
        public HomeController(IProductService _productService, ApplicationDbContext _dbContext, IShoppingCartService _shoppingCartService, IRepository _repo)
        {
            productService = _productService;
          
        }

        public async Task<IActionResult> Index()
        {
            var model = await productService.GetProductWithMostReviews();

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}