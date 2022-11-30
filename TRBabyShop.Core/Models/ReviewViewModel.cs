using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Models
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        [Required]
        public AppUser User { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [StringLength(Common.Constants.MaxReviewTextLength, MinimumLength = Common.Constants.MinReviewTextLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Text { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [Required]
        public string Product { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
