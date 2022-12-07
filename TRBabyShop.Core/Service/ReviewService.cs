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

            var product = await repo.GetByIdAsync<Product>(model.ProductId);

            model.Product = product.Name;
           
            if (product == null)
            { 
                throw new ArgumentException("Invalid product !");
            }

            var user = await repo.GetByIdAsync<AppUser>(userId);
            model.User = user.UserName;

            if (user == null)
            { 
                throw new ArgumentException("Invalid user !");
            }

            else
            {
                var newReview = new Review()
                {
                    ProductId = model.ProductId,
                    UserId = user.Id,
                    Text = model.Text,
                    CreatedOn = DateTime.Now

                };
                

                product?.Reviews.Add(newReview);
                user?.UserReviews.Add(newReview);
                await dbContext.Reviews.AddAsync(newReview);
                await dbContext.SaveChangesAsync();
            }

        }

        
        public async Task DeleteReview(int reviewId)
        {
            var review =  dbContext.Reviews.Where(r => r.Id == reviewId);

            if (review == null)
            {
            throw new ArgumentException("Invalid review.");
            }
            

           dbContext.Remove(reviewId);
            dbContext.Update(review);
          await dbContext.SaveChangesAsync();

           
        }

        public async Task<IEnumerable<ReviewViewModel>> GetProductReviews(int productId)
        {
           
                var reviews = await dbContext.Reviews.Where(r=>r.ProductId==productId)
                .Include(r=>r.User)
                    .ToListAsync();

                return reviews
                    .Select(r => new ReviewViewModel()
                    {
                       Id= r.Id,
                       UserId = r.UserId,
                       CreatedOn=r.CreatedOn,
                       Text=r.Text,
                    });
        }
    }
}
