using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IOrderService orderService;
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
        public async Task<IActionResult> All()
        {
            var orderList = await orderService.GetOrderAsync();

            return View(orderList);
        }

        public IActionResult Details(int orderId)
        {
            var orderVM = new OrderViewModel()
            {
                Order = dbcontext.Orders.FirstOrDefault(o => o.Id == orderId),
                OrderDetail = dbcontext.OrderDetails
                .Where(od => od.OrderId == orderId)
                .Include(od => od.Product)
            };

            return View(orderVM);
        }
    }
}
