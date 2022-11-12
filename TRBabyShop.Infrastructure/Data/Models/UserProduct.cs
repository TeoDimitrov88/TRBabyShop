
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRBabyShop.Infrastructure.Data.Models

{
    public class UserProduct
    {
        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
