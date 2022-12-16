using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class CategoryViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.Constants.MaxCategoryNameLength, MinimumLength = Common.Constants.MinCategoryNameLength, ErrorMessage = "{0} length must be between {2} and {1} characters long!")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(Common.Constants.MaxImageUrlLength, MinimumLength = Common.Constants.MinImageUrlLength, ErrorMessage = "{0} length must be between {2} and {1} characters long!")]
        public string Image { get; set; } = null!;

        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
