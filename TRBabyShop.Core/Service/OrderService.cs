using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Service
{
    public class OrderService:IOrderService
    {
        private readonly ApplicationDbContext dbContext;

        public OrderService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

       
        
        public async Task<IEnumerable<Order>> GetOrderAsync()
        {
            var orders = await dbContext.Orders.Include(o => o.User)
                .ToListAsync();

            return orders
                .Select(o => new Order()
                
                {
                    Id = o.Id,
                    UserId = o.UserId,
                    Name = o.Name,
                    Email = o.User.Email,
                    City = o.City,
                    PostCode = o.PostCode,
                    PaymentStatus = o.PaymentStatus,
                    OrderStatus = o.OrderStatus,
                    OrderDate = o.OrderDate,
                    OrderTotal = o.OrderTotal,
                    SessionId = o.SessionId
                });
        }

      
        public void Update(Order order)
        {
            dbContext.Orders.Update(order);
        }

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFromDb = dbContext.Orders.FirstOrDefault(o => o.Id == id);
            if (orderFromDb!= null)
            {
                orderFromDb.OrderStatus = orderStatus;
                if (paymentStatus!=null)
                {
                    orderFromDb.PaymentStatus = paymentStatus;
                }
            }
        }

        public void UpdateStripePaymentId(int id, string sessionId, string paymentIntentId)
        {
            var orderFromDb = dbContext.Orders.FirstOrDefault(o => o.Id == id);
           
            
            orderFromDb.SessionId = sessionId;
            orderFromDb.PaymentIntentId = paymentIntentId;
        }
    }
}
