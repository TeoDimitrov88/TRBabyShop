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
        public int Id { get; set; }
        public Product Product { get; set; } = null!;

        public string User { get; set; }
        public string UserId { get; set; }

        public int ProductId { get; set; }

        [Range(1,100,ErrorMessage ="Please enter a value between 1 and 100!")]
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

    }
}
