using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;
using TRBabyShop.Models;

namespace TRBabyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly ApplicationDbContext dbContext;
        private readonly IShoppingCartService shoppingCartService;
        private readonly IRepository repo;
        public HomeController(IProductService _productService,ApplicationDbContext _dbContext,IShoppingCartService _shoppingCartService, IRepository _repo)
        {
           productService = _productService;
            dbContext = _dbContext;
            shoppingCartService = _shoppingCartService;
            repo=_repo;
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