using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Core.Models
{
    public class CartListViewModel
    {
        public IEnumerable<ShoppingCartViewModel> ListCart { get; set; }

        public decimal cartTotal { get; set; }
    }
}
