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

            var user = await repo.GetByIdAsync<AppUser>(userId);
            //model.User = user.UserName;

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
        public async Task<ReviewViewModel> GetReviewById(int reviewId)
        {
            var review=await repo.GetByIdAsync<Review>(reviewId);
            if (review==null)
            {
                throw new ArgumentException("Invalid review");
            }
            var model = new ReviewViewModel()
            {
                Id = reviewId,
                ProductId = review.ProductId,
                UserId = review.UserId,
                Text = review.Text,
                CreatedOn = review.CreatedOn
            };

            return model;
        }

        
        public async Task<int> DeleteReview(int reviewId)
        {
            var review =  await repo.GetByIdAsync<Review>(reviewId);

            if (review==null)
            {
                throw new ArgumentException("Invalid review!");
            }
           await repo.DeleteAsync<Review>(review.Id);

            repo.Update(review);
            await repo.SaveChangesAsync();

            return review.ProductId;
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
                       User=r.User.UserName,
                       UserId = r.UserId,
                       CreatedOn=r.CreatedOn,
                       Text=r.Text,
                    });
        }
    }
}
