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

        public async Task AddReview(ReviewViewModel model, string userId)
        {

            var product = await dbContext.Products.FirstOrDefaultAsync(p => p.Id == model.ProductId);
            if (product == null)
            { 
                throw new ArgumentException("Invalid product Id!");
            }


            var user = await dbContext.Users.Where(u => u.Id == userId).Include(u => u.UserReviews).FirstOrDefaultAsync();
            if (user == null)
            { 
                throw new ArgumentException("Invalid user Id!");
            }

            else
            {
                var newReview = new Review()
                {
                    ProductId = model.ProductId,
                    UserId = model.UserId,
                    Text = model.Text,
                    CreatedOn = model.CreatedOn

                };
                product?.Reviews.Add(newReview);
                user?.UserReviews.Add(newReview);
                await dbContext.Reviews.AddAsync(newReview);
                await dbContext.SaveChangesAsync();
            }

        }

        
        public async Task<int> DeleteReview(int reviewId)
        {
            var review = await repo.GetByIdAsync<Review>(reviewId);

            if (review == null)
            {
            throw new ArgumentException("Invalid review.");
            }

            await repo.DeleteAsync<Review>(reviewId);
            await repo.SaveChangesAsync();

            return review.Id;
        }

        public async Task<IEnumerable<ReviewViewModel>> GetProductReviews(int productId)
        {
            return await repo.AllReadonly<Review>()
                 .Where(r => r.ProductId == productId)
                 .Select(r => new ReviewViewModel()
                 {
                     Id = r.Id,
                     UserId = r.UserId,
                     ProductId = r.ProductId,
                     Text = r.Text,
                     CreatedOn = r.CreatedOn,
                     User = r.User.UserName
                 }).ToListAsync();
        }
    }
}
