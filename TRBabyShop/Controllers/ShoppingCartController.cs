using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;
using static TRBabyShop.Infrastructure.Data.Common.Constants;

namespace TRBabyShop.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCartService;
        private readonly ApplicationDbContext dbContext;
        [BindProperty]
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
                .Select(x=>new ShoppingCart()
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
                ListCart = listCartAdd,
                Order = new()

            };

            foreach (var cart in cartVM.ListCart)
            {
                cartVM.Order.OrderTotal += (cart.Price * cart.Quantity);
            }
            return View(cartVM);
        }

        public IActionResult Summary()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var listCartAdd = dbContext.ShoppingCarts.Where(u => u.UserId == claim.Value)
                .Select(x => new ShoppingCart()
                {
                    Id = x.Id,
                    Price = x.Product.Price,
                    UserId = x.UserId,
                    Product = x.Product,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    Total = x.Quantity * x.Product.Price,
                    Order = x.Order
                }).ToList();

            cartVM = new CartListViewModel
            {
                ListCart = listCartAdd,
                Order = new()
            };
            cartVM.Order.User = dbContext.Users.FirstOrDefault(u => u.Id == claim.Value);

            
            foreach (var cart in cartVM.ListCart)
            {
                cartVM.Order.OrderTotal += (cart.Price * cart.Quantity);
            }
            return View(cartVM);
        }

        [HttpPost]
        [ActionName("Summary")]
        [ValidateAntiForgeryToken]
        public IActionResult SummaryPost()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //var listCartAdded = dbContext.ShoppingCarts.Where(u => u.UserId == claim.Value).ToList();
            
            var listCartAdd = dbContext.ShoppingCarts.Where(u => u.UserId == claim.Value)
                .Select(x => new ShoppingCart()
                {
                    Id = x.Id,
                    Price = x.Product.Price,
                    UserId = x.UserId,
                    Product = x.Product,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    Total = x.Quantity * x.Product.Price,
                    Order = x.Order
                }).ToList();

            cartVM.ListCart = listCartAdd;


            cartVM.Order.PaymentStatus = Status.PaymentStatusPending;
            cartVM.Order.OrderStatus = Status.PendingStatus;
            cartVM.Order.OrderDate= DateTime.Now;
            cartVM.Order.UserId = claim.Value;


            foreach (var cart in cartVM.ListCart)
            {
                cartVM.Order.OrderTotal += (cart.Price * cart.Quantity);
            }

            dbContext.Orders.Add(cartVM.Order);
            dbContext.SaveChanges();

            foreach (var cart in cartVM.ListCart)
            {
                OrderDetail orderDetails = new()
                {
                    ProductId = cart.ProductId,
                    OrderId = cartVM.Order.Id,
                    Price = cart.Price,
                    Quantity = cart.Quantity
                };

                dbContext.OrderDetails.Add(orderDetails);
                dbContext.SaveChanges();
            }

            dbContext.ShoppingCarts.RemoveRange(cartVM.ListCart);
            dbContext.SaveChanges();


            return RedirectToAction("All", "Product");
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
