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

        public string User { get; set; } = null!;
        public string UserId { get; set; } = null!;

        public int ProductId { get; set; }

        [Range(1,100,ErrorMessage ="Please enter a value between 1 and 100!")]
        public int Quantity { get; set; }
        [Range(typeof(decimal), "0.0", "1500000.00", ConvertValueInInvariantCulture = true)]
        public decimal Price { get; set; }
        [Range(typeof(decimal), "0.0", "1500000.00", ConvertValueInInvariantCulture = true)]
        public decimal Total { get; set; }

        public Order Order { get; set; } = null!;
    }
}
