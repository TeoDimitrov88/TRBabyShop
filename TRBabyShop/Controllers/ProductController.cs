using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;
using TRBabyShop.Models;

namespace TRBabyShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ApplicationDbContext dbContext;
        private readonly IShoppingCartService shoppingCartService;

        public ProductController(IProductService _productService, ApplicationDbContext _dbContext, IShoppingCartService _shoppingCartService)
        {
            productService = _productService;
            dbContext = _dbContext;
            shoppingCartService= _shoppingCartService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await productService.GetProductAsync();
            return View(model);
        }

        public async Task<IActionResult> ProductsByCategory(int categoryId)
        {
            var model=await productService.GetProductsByCategoryAsync(categoryId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var category = await productService.GetCategoriesAsync();
            var model = new AddProductViewModel()
            {
                Categories = category
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await productService.AddProductAsync(model);

               
            }
            catch (Exception ex)
            {
                var error = new ErrorViewModel
                {
                    RequestId=ex.Message
                };
                return View("Error", error);
            }
            return RedirectToAction(nameof(All));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int productId)
        {
            await productService.DeleteProduct(productId);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int productId)
        {
            if (productId==0)
            {
                return NotFound();
            }
            var product = await productService.GetProductUpdateAsync(productId);

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int productId, Product model)
        {
            await productService.UpdateProductAsync(productId, model);


            return RedirectToAction(nameof(All));
        }

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
        [Authorize]

        public IActionResult Details(ShoppingCartViewModel shoppingCart)
        {
            

            var claimsIdentity=(ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            shoppingCart.UserId = claim.Value;

            ShoppingCart cartFromDb = dbContext.ShoppingCarts.FirstOrDefault(u => u.UserId == claim.Value && u.ProductId == shoppingCart.ProductId);

            ShoppingCart addCart = new ShoppingCart()
            {
                ProductId = shoppingCart.ProductId,
                UserId = shoppingCart.UserId,
                Quantity = shoppingCart.Quantity
            };

            if (cartFromDb==null)
            { 
               
                dbContext.ShoppingCarts.Add(addCart);
                dbContext.SaveChanges();
                //object session = HttpContext.Session.SetInt32(ServiceDescriptor.SessionCart, dbContext.ShoppingCarts.All(u => u.UserId == claim.Value).Count);
            }
            else
            {
               
                shoppingCartService.IncreaseCount(cartFromDb, addCart.Quantity);
                dbContext.SaveChanges();
            }

            return RedirectToAction(nameof(All));
        }
    }
}
