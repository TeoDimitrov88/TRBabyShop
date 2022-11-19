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
        public Product Product { get; set; } = null!;

        [Range(1,100,ErrorMessage ="Please enter a value between 1 and 100!")]
        public int Quantity { get; set; } 

    }
}
