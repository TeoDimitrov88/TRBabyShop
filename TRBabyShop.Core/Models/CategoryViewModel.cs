using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class CategoryViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.Constants.MaxCategoryNameLength,MinimumLength =Common.Constants.MinCategoryNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
