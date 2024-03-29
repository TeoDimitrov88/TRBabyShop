﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Infrastructure.Data.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        [Range(1,1000,ErrorMessage ="Quantity must be between 1 and 1000")]
        public int Quantity { get; set; }

        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; } = null!;

        [NotMapped]
        public decimal Price { get; set; }
        [NotMapped]
        public decimal Total { get; set; }

        [NotMapped]
        public Order Order { get; set; }
    }
}
