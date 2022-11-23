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
        void Update(Order order);

        void UpdateStatus(int id, string orderStatus, string? paymentStatus = null);

    }
}
