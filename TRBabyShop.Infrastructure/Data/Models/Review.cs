
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TRBabyShop.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; } = null!;


        [Required]
        [StringLength(500)]
        public string Text { get; set; } = null!;


        [Required]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
