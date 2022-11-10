using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Models;

namespace TRBabyShop.Core.Contracts
{
    public interface IReviewService
    {
        Task<IEnumerable<AllReviewsViewModel>> GetProductReviews(int productId);
    }
}
