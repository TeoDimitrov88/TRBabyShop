﻿using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class UpdateProductVM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.Constants.MaxProductNameLength, MinimumLength = Common.Constants.MinProductNameLength, ErrorMessage = "{0} length must be between {2} and {1} !")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(Common.Constants.MaxDescriptionLength, MinimumLength = Common.Constants.MinDescriptionLength, ErrorMessage = "{0} length must be between {2} and {1} !")]

        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "0.0", "1500000.00", ConvertValueInInvariantCulture = true, ErrorMessage = "{0} value must be between {2} and {1} !")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(Common.Constants.MaxImageUrlLength, MinimumLength = Common.Constants.MinImageUrlLength, ErrorMessage = "{0} length must be between {2} and {1} !")]
        public string Image { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    
    }
}
