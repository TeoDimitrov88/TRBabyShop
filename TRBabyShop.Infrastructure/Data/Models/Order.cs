using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Infrastructure.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; } = null!;
        [Required]
        public string City { get; set; } = null!;
        [Required]
        public string PostCode { get; set; } = null!;

        [Required]
        public DateTime OrderDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public decimal OrderTotal { get; set; }

        public string? OrderStatus { get; set; }

        public string? PaymentStatus { get; set; }

        public string? SessionId  { get; set; }

        public string? PaymentIntentId  { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;


    }
}
