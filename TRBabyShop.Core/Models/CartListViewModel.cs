using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class CartListViewModel
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; }

        public decimal cartTotal { get; set; }

        public Order Order { get; set; }
    }
}
