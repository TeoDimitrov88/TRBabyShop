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
    [Authorize(Roles = Status.RoleAdmin + "," + Status.RoleCustomer)]
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

        /// <summary>
        /// Getting all orders method
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> All(string status)
        {
            IEnumerable<Order> orderList;

            if (User.IsInRole(Status.RoleAdmin))
            {
                orderList = await orderService.GetOrderAsync();
            }


            else
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                orderList = dbcontext.Orders.Where(u => u.UserId == claim.Value).Include(u => u.User);

            }

            if (status == "pending")
            {
                orderList = orderList.Where(o => o.OrderStatus == Status.PendingStatus);
            }
            else if (status == "processing")
            {
                orderList = orderList.Where(o => o.OrderStatus == Status.StatusInProcess);
            }
            else if (status == "completed")
            {
                orderList = orderList.Where(o => o.OrderStatus == Status.ShippedStatus);
            }
            else if (status == "approved")
            {
                orderList = orderList.Where(o => o.OrderStatus == Status.ApprovedStatus);
            }


            return View(orderList);
        }

        /// <summary>
        /// Getting details for every order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public IActionResult Details(int orderId)
        {

            OrderVM = new OrderViewModel()
            {
                Order = dbcontext.Orders.FirstOrDefault(o => o.Id == orderId),
                OrderDetail = dbcontext.OrderDetails
                .Where(od => od.OrderId == orderId)
                .Include(od => od.Product)
                .Include(od => od.Order.User)
            };


            return View(OrderVM);
        }

        /// <summary>
        /// Updating order details 
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        [Authorize(Roles = Status.RoleAdmin)]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateOrderDetail()
        {
            var orderFromDb = dbcontext.Orders.FirstOrDefault(o => o.Id == OrderVM.Order.Id);
            orderFromDb.Name = OrderVM.Order.Name;
            orderFromDb.Email = OrderVM.Order.Email;
            orderFromDb.City = OrderVM.Order.City;
            orderFromDb.OrderStatus = OrderVM.Order.OrderStatus;
            orderFromDb.PaymentStatus = OrderVM.Order.PaymentStatus;
            orderFromDb.PostCode = OrderVM.Order.PostCode;


            dbcontext.Orders.Update(orderFromDb);
            dbcontext.SaveChanges();

            return RedirectToAction("Details", "Order", new { orderId = orderFromDb.Id });
        }

        /// <summary>
        /// Start processing the order if payment is confirmed
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        [Authorize(Roles = Status.RoleAdmin)]
        [ValidateAntiForgeryToken]

        public IActionResult StartProcessing()
        {

            var orderFromDb = dbcontext.Orders.FirstOrDefault(o => o.Id == OrderVM.Order.Id);
            orderFromDb.OrderStatus = Status.StatusInProcess;

            dbcontext.Update(orderFromDb);
            dbcontext.SaveChanges();

            return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
        }

        /// <summary>
        /// Shipping order method
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        [Authorize(Roles = Status.RoleAdmin)]
        [ValidateAntiForgeryToken]
        public IActionResult ShipOrder()
        {
            var orderFromDb = dbcontext.Orders.FirstOrDefault(u => u.Id == OrderVM.Order.Id);

            orderFromDb.OrderStatus = Status.ShippedStatus;
            orderFromDb.ShippingDate = DateTime.Now;

            orderService.Update(orderFromDb);
            dbcontext.SaveChanges();

            return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
        }        

        /// <summary>
        /// cancel order method
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        [Authorize(Roles = Status.RoleAdmin)]
        [ValidateAntiForgeryToken]
        public IActionResult CancelOrder()
        {
            var orderFromDb = dbcontext.Orders.FirstOrDefault(o => o.Id == OrderVM.Order.Id);


            orderFromDb.OrderStatus = Status.CancelledStatus;
            orderFromDb.PaymentStatus = Status.CancelledStatus;

            orderService.Update(orderFromDb);

            dbcontext.SaveChanges();


            return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
        }
    }
}
