using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;
using System.Security.Claims;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;
using static TRBabyShop.Infrastructure.Data.Common.Constants;

namespace TRBabyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IOrderService orderService;

        [BindProperty]
        public OrderViewModel OrderVM { get; set; }
        public OrderController(ApplicationDbContext _dbcontext, IOrderService _orderService)
        {
            dbcontext = _dbcontext;
            orderService = _orderService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> All(string status)
        {
            //if (User.IsInRole(Status.RoleAdmin))
            //{

            //}
            var orderList = await orderService.GetOrderAsync();

            //else
            //{
            //    var claimsIdentity = (ClaimsIdentity)User.Identity;
            //    var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //    orderList = dbcontext.Orders.Where(u => u.UserId == claim.Value).Include(u => u.User);
            //}

            if (status=="pending")
            {
                orderList = orderList.Where(p => p.PaymentStatus == Status.PaymentStatusPending);
            }
            else if (status=="inprocess")
            {
                orderList = orderList.Where(p => p.PaymentStatus == Status.StatusInProcess);
            }
            else if (status=="completed")
            {
                orderList = orderList.Where(p => p.PaymentStatus == Status.ShippedStatus);
            }
            else if (status == "approved")
            {
                orderList = orderList.Where(p => p.PaymentStatus == Status.ApprovedStatus);
            }
            return View(orderList);
        }

        public IActionResult Details(int orderId)
        {
          
            OrderVM = new OrderViewModel()
            {
                Order = dbcontext.Orders.FirstOrDefault(o=>o.Id==orderId),
                OrderDetail = dbcontext.OrderDetails
                .Where(od => od.OrderId == orderId)
                .Include(od => od.Product)
                .Include(od=>od.Order.User)
            };
            

            return View(OrderVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateOrderDetail()
        {
            var orderFromDb = dbcontext.Orders.FirstOrDefault(o => o.Id == OrderVM.Order.Id);
            orderFromDb.Name=OrderVM.Order.Name;
            orderFromDb.Email = OrderVM.Order.Email;
            orderFromDb.City= OrderVM.Order.City;
            orderFromDb.OrderStatus= OrderVM.Order.OrderStatus;
            orderFromDb.PaymentStatus=OrderVM.Order.PaymentStatus;
            orderFromDb.PostCode = OrderVM.Order.PostCode;

            dbcontext.Orders.Update(orderFromDb);
            dbcontext.SaveChanges();

            return RedirectToAction("Details","Order",new {id=orderFromDb.Id});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult StartProcessing()
        {

           var orderFromDb= dbcontext.Orders.FirstOrDefault(o => o.Id == OrderVM.Order.Id);
            orderFromDb.OrderStatus = Status.StatusInProcess;

            dbcontext.Update(orderFromDb);
            dbcontext.SaveChanges();

            return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult ShipOrder()
        {
            var orderFromDb = dbcontext.Orders.FirstOrDefault(u => u.Id == OrderVM.Order.Id);
           
            orderFromDb.OrderStatus=Status.ShippedStatus;
            orderFromDb.ShippingDate = DateTime.Now;

            orderService.Update(orderFromDb);
            dbcontext.SaveChanges();

            return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
        }

        [ActionName("Details")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details_Pay_Now()
        {
            OrderVM.Order = dbcontext.Orders.FirstOrDefault(o => o.Id == OrderVM.Order.Id);
            OrderVM.OrderDetail = dbcontext.OrderDetails.Where(o => o.OrderId == OrderVM.Order.Id).Include(o => o.Product);

            //stripe settings below
            var domain = "https://localhost:7079/";
            var options = new SessionCreateOptions()
            {
                PaymentMethodTypes=new List<string>
                {
                    "card"
                },
                LineItems= new List<SessionLineItemOptions>(),
            Mode="payment",
            SuccessUrl=domain + $"admin/order/PaymentConfirmation?orderid={OrderVM.Order.Id}",
            CancelUrl=domain + $"admin/order/details?orderId={OrderVM.Order.Id}"
            };

            foreach (var item in OrderVM.OrderDetail)
            {
                var sessionlineItem = new SessionLineItemOptions
                {
                    PriceData=new SessionLineItemPriceDataOptions
                    {
                        UnitAmount=(long)(item.Price*100),
                        Currency="bgn",
                        ProductData=new SessionLineItemPriceDataProductDataOptions 
                        {
                         Name=item.Product.Name
                        },
                    },
                    Quantity=item.Quantity,
                };

                options.LineItems.Add(sessionlineItem);
            }

            var service = new SessionService();
            Session session = service.Create(options);

            orderService.UpdateStripePaymentId(OrderVM.Order.Id, session.Id, session.PaymentIntentId);
            dbcontext.SaveChanges();
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
    }
}
