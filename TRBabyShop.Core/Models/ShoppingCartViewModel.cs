using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class ShoppingCartViewModel
    {
        public IEnumerable<ShoppingCart> CartList { get; set; }

        public Order Order { get; set; } = null!;

    }
}
