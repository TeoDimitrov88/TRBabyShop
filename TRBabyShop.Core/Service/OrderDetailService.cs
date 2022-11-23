using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Service
{
    public class OrderDetailService:IOrderDetailService
    {
        private readonly ApplicationDbContext dbContext;

        public OrderDetailService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public void Update(OrderDetail orderDetails)
        {
            dbContext.OrderDetails.Update(orderDetails);
        }
    }
}
