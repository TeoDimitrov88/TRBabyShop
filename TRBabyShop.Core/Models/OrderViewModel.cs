using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; } = null!;

        public IEnumerable<OrderDetail> OrderDetail { get; set; } = null!;

    }
}
