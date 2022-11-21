using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;

namespace TRBabyShop.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCartService;
        private readonly ApplicationDbContext dbContext;
        public CartListViewModel cart { get; set; }
        public ShoppingCartController(IShoppingCartService _shoppingCartService, ApplicationDbContext _dbContext)
        {
            shoppingCartService = _shoppingCartService;
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var listCartAdd= dbContext.ShoppingCarts.Where(u => u.UserId == claim.Value)
                .Select(x=>new ShoppingCartViewModel()
                {
                   UserId=x.UserId,
                   Product=x.Product,
                   ProductId=x.ProductId,
                   Quantity=x.Quantity
                }).ToList();

            cart = new CartListViewModel
            {
                ListCart = listCartAdd
            };
            return View(listCartAdd);
        }
    }
}
