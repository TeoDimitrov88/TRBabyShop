using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Contracts
{
    public interface IOrderService
    {
   
        Task<IEnumerable<Order>> GetOrderAsync();
        void Update(Order order);

        void UpdateStatus(int id, string orderStatus, string? paymentStatus = null);

        void UpdateStripePaymentId(int id, string sessionId, string paymentIntentId);
    }
}
