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
        public CartListViewModel cartVM { get; set; }
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
                    Id=x.Id,
                    Price=x.Product.Price,
                   UserId=x.UserId,
                   Product=x.Product,
                   ProductId=x.ProductId,
                   Quantity=x.Quantity,
                   Total=x.Quantity*x.Product.Price
                }).ToList();

            cartVM = new CartListViewModel
            {
                ListCart = listCartAdd
            };

            foreach (var cart in cartVM.ListCart)
            {
                cartVM.cartTotal += (cart.Price * cart.Quantity);
            }
            return View(listCartAdd);
        }

        public IActionResult Plus(int cartId)
        {
            var cart = dbContext.ShoppingCarts.FirstOrDefault(u => u.Id == cartId);
            shoppingCartService.IncreaseCount(cart, 1);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Minus(int cartId)
        {
            var cart = dbContext.ShoppingCarts.FirstOrDefault(u => u.Id == cartId);
            if (cart.Quantity<=1)
            {
                dbContext.ShoppingCarts.Remove(cart);
            }
            else
            {
                shoppingCartService.DecreaseCount(cart, 1);
            }
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int cartId)
        {
            var cart = dbContext.ShoppingCarts.FirstOrDefault(c => c.Id == cartId);
            dbContext.ShoppingCarts.Remove(cart);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
