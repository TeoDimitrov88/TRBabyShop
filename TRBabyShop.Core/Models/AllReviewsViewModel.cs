using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Core.Models
{
    public class AllReviewsViewModel
    {
        public int ReviewId { get; set; }

        public string? Text { get; set; }

        public int? ProductId { get; set; }

        public string? Product { get; set; }
        public string? Username { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
