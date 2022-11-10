using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Service
{
    public class ReviewService : IReviewService
    {
       private readonly ApplicationDbContext dbContext;
       private readonly IRepository repo;

        public ReviewService(ApplicationDbContext _dbContext, IRepository _repo)
        {
            dbContext = _dbContext;
            repo = _repo;
        }
        public async Task<IEnumerable<AllReviewsViewModel>> GetProductReviews(int productId)
        {
            return await repo.AllReadonly<Review>()
                 .Where(r => r.ProductId == productId)
                 .Select(r => new AllReviewsViewModel()
                 {
                     ReviewId = r.Id,
                     ProductId = r.ProductId,
                     Text = r.Text,
                     CreatedOn=r.CreatedOn,
                     Username=r.User.UserName
                 }).ToListAsync();
        }
    }
}
