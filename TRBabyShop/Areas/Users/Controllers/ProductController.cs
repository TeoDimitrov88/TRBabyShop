using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ApplicationDbContext dbContext;
        private readonly IShoppingCartService shoppingCartService;

        public ProductController(IProductService _productService, ApplicationDbContext _dbContext, IShoppingCartService _shoppingCartService)
        {
            productService = _productService;
            dbContext = _dbContext;
            shoppingCartService = _shoppingCartService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await productService.GetProductAsync();
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ProductsByCategory(int categoryId)
        {
            var model = await productService.GetProductsByCategoryAsync(categoryId);

            return View(model);
        }


        [AllowAnonymous]
        public async Task<IActionResult> GetById(int productId)
        {
            var model = await productService.GetProductById(productId);
            return View(model);
        }

       
        public IActionResult Details(int productId)
        {
            ShoppingCartViewModel cart = new()
            {
                Quantity = 1,
                ProductId = productId,
                Product = dbContext.Products.FirstOrDefault(p => p.Id == productId)


            };

            return View(cart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]

        public IActionResult Details(ShoppingCartViewModel shoppingCart)
        {

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            shoppingCart.UserId = claim.Value;

            ShoppingCart cartFromDb = dbContext.ShoppingCarts.FirstOrDefault(u => u.UserId == claim.Value && u.ProductId == shoppingCart.ProductId);

            ShoppingCart addCart = new ShoppingCart()
            {
                ProductId = shoppingCart.ProductId,
                UserId = shoppingCart.UserId,
                Quantity = shoppingCart.Quantity
            };

            if (cartFromDb == null)
            {

                dbContext.ShoppingCarts.Add(addCart);
                dbContext.SaveChanges();
            }
            else
            {

                shoppingCartService.IncreaseCount(cartFromDb, addCart.Quantity);
                dbContext.SaveChanges();
            }

            return RedirectToAction("Index","ShoppingCart");
        }
    }
}
