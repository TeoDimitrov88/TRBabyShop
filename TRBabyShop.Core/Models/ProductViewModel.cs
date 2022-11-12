using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.Constants.MaxProductNameLength, MinimumLength = Common.Constants.MinProductNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(Common.Constants.MaxDescriptionLength, MinimumLength = Common.Constants.MinDescriptionLength)]

        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "0.0", "1500000.00", ConvertValueInInvariantCulture = true)]
        public decimal Price { get; set; }

        [Required]
        public string Image { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public ICollection<Review> Reviews { get; set; } = null!;
    }
}
