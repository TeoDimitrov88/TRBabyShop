using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Infrastructure.Data.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        [ForeignKey(nameof(OrderId))]
        [ValidateNever]
        public Order Order { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        [ValidateNever]
        public Product Product { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        public decimal Price { get; set; }

    }
}
