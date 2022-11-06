using System.ComponentModel.DataAnnotations;

namespace TRBabyShop.Models
{
    public class CategoryViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.Constants.MaxCategoryNameLength,MinimumLength =Common.Constants.MinCategoryNameLength)]
        public string Name { get; set; } = null!;
    }
}
