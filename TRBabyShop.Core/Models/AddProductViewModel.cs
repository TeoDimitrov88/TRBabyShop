﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class AddProductViewModel
    {
        [Required]
        [StringLength(Common.Constants.MaxProductNameLength, MinimumLength = Common.Constants.MinProductNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(5000)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "0.0", "15000.00", ConvertValueInInvariantCulture = true)]
        public decimal Price { get; set; }

        [Required]
        public string Image { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}