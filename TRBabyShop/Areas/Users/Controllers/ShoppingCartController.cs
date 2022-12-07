using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;
using static TRBabyShop.Infrastructure.Data.Common.Constants;

namespace TRBabyShop.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize(Roles = Status.RoleAdmin + "," + Status.RoleCustomer)]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCartService;
        private readonly IOrderService orderService;
        private readonly ApplicationDbContext dbContext;

        [BindProperty]
        public CartListViewModel cartVM { get; set; }
        public ShoppingCartController(IShoppingCartService _shoppingCartService, IOrderService _orderService, ApplicationDbContext _dbContext)
        {
            shoppingCartService = _shoppingCartService;
            orderService = _orderService;
            dbContext = _dbContext;
        }
        public IActionResult Index()
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
                    Total = x.Quantity * x.Product.Price
                }).ToList();


            cartVM = new CartListViewModel
            {
                ListCart = listCartAdd,
                Order = new()

            };

            foreach (var cart in cartVM.ListCart)
            {
                cartVM.Order.OrderTotal += cart.Price * cart.Quantity;
            }
            return View(cartVM);
        }

        public IActionResult Summary()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var listCartAdd = dbContext.ShoppingCarts.Where(u => u.UserId == claim.Value)
                .Include(u=>u.Product)
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
            cartVM.Order.Name = cartVM.Order.User.UserName;
            cartVM.Order.Email = cartVM.Order.User.Email;


            foreach (var cart in cartVM.ListCart)
            {
                cartVM.Order.OrderTotal += cart.Price * cart.Quantity;
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

            var listCartAdd = dbContext.ShoppingCarts.Where(u => u.UserId == claim.Value)
                .Include(u=>u.Product)
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

            

            cartVM.Order.OrderDate = DateTime.Now;
            cartVM.Order.UserId = claim.Value;
            cartVM.Order.Name = claimsIdentity.Name;
            cartVM.Order.Email = cartVM.Order.User.Email;
            cartVM.Order.PaymentStatus = Status.PaymentStatusApproved;
            cartVM.Order.OrderStatus = Status.ApprovedStatus;


            foreach (var cart in cartVM.ListCart)
            {
                cartVM.Order.OrderTotal += cart.Price * cart.Quantity;
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
            //Stripe settings below
            var domain = "https://localhost:7079/";
            var options = new SessionCreateOptions
            {
               
                LineItems = new List<SessionLineItemOptions>(),
                
                Mode = "payment",
                SuccessUrl = domain + $"Users/ShoppingCart/OrderConfirmation?id={cartVM.Order.Id}",
                CancelUrl = domain + $"Users/ShoppingCart",
            };

            foreach (var item in cartVM.ListCart)
            {

                var sessionLineItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(item.Price * 100),
                        Currency = "bgn",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Product.Name,
                        },
                    },
                    Quantity = item.Quantity,
                };

                options.LineItems.Add(sessionLineItem);

            }
            var service = new SessionService();
            Session session = service.Create(options);
            cartVM.Order.SessionId = session.Id;
    orderService.UpdateStripePaymentId(cartVM.Order.Id, session.Id, session.PaymentIntentId);
            dbContext.SaveChanges();


            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);

        }

        public IActionResult OrderConfirmation(int id)
        {
            Order order = dbContext.Orders.FirstOrDefault(u => u.Id == id);

            var service = new SessionService();
            Session session = service.Get(order.SessionId);

            //checking the stripe status
            if (session.PaymentStatus.ToLower() == "paid")
            {
                orderService.UpdateStatus(id, Status.ApprovedStatus, Status.PaymentStatusApproved);
                dbContext.SaveChanges();
            }
            List<ShoppingCart> shoppingCarts = dbContext.ShoppingCarts.Where(u => u.UserId == order.UserId).ToList();
            dbContext.ShoppingCarts.RemoveRange(shoppingCarts);
            dbContext.SaveChanges();

            return View(id);
        }
        public IActionResult Plus(int cartId)
        {
            var cart = dbContext.ShoppingCarts.FirstOrDefault(u => u.Id == cartId);
            shoppingCartService.IncreaseCount(cart, 1);
            dbContext.ShoppingCarts.Update(cart);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Minus(int cartId)
        {
            var cart = dbContext.ShoppingCarts.FirstOrDefault(u => u.Id == cartId);
            if (cart.Quantity <= 1)
            {
                dbContext.ShoppingCarts.Remove(cart);
            }
            else
            {
                shoppingCartService.DecreaseCount(cart, 1);
                dbContext.ShoppingCarts.Update(cart);
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
