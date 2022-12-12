using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Models;
using TRBabyShop.Core.Service;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Tests
{
    public class ReviewServiceTests
    {
        [Fact]
        public async void TestAddNewReview()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test42");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var repo = new Repository(dbContext);

            var reviewService = new ReviewService(dbContext,repo);
            var product = new Product()
            {
                Id = 1,
                Name = "product",
                Description="description",
                Price=10,
                Image="image.jpg"
            };
            var user = new AppUser()
            {
                Id = "12345",
                UserName="User1"
            };

            ReviewViewModel newReview = new ReviewViewModel()
            {

                Text = "Very good product",
                UserId= "12345",
                ProductId=1,
                CreatedOn=DateTime.Now
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
           
            await reviewService.AddReview(newReview,newReview.UserId);

            await dbContext.SaveChangesAsync();
            var result = await dbContext.Reviews.ToListAsync();

            Assert.Equal(1, result.Count);
        }

        [Fact]
        public async void TestAddNewReviewThrowsArgumetnExceptionForInvalidUser()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test44");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var repo = new Repository(dbContext);

            var reviewService = new ReviewService(dbContext, repo);
            var product = new Product()
            {
                Id = 1,
                Name = "product",
                Description = "description",
                Price = 10,
                Image = "image.jpg",
                CategoryId = 1
            };
            var user = new AppUser()
            {
                Id = "12345",
                UserName = "User1"
            };

            ReviewViewModel newReview = new ReviewViewModel()
            {
                Id=1,
                Text = "Very good product",
                UserId = user.Id,
                ProductId = product.Id,
                CreatedOn = DateTime.Now
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            await reviewService.AddReview(newReview, newReview.UserId);

            await dbContext.SaveChangesAsync();
            var result = await dbContext.Reviews.Where(p=>p.ProductId==product.Id).Include(u=>u.User). ToListAsync();

          await  Assert.ThrowsAsync<ArgumentException>(() => reviewService.AddReview(newReview, "e3423"));
        }

        [Fact]
        public async void TestGetProductReviews()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test46");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var repo = new Repository(dbContext);

            var reviewService = new ReviewService(dbContext, repo);
            var product = new Product()
            {
                Id = 1,
                Name = "product",
                Description = "description",
                Price = 10,
                Image = "image.jpg",
                CategoryId=1
            };
            var user = new AppUser()
            {
                Id = "12345",
                UserName = "User1"
            };

            Review newReview = new Review()
            {
                Id=55,
                Text = "Very good product",
                UserId = user.Id,
                ProductId = product.Id,
                CreatedOn = DateTime.Now
            };
            Review newReview2 = new Review()
            {
                Id=56,
                Text = "Very good product",
                UserId = user.Id,
                ProductId = product.Id,
                CreatedOn = DateTime.Now
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            await dbContext.Reviews.AddAsync(newReview);
            await dbContext.Reviews.AddAsync(newReview2);
           
            await dbContext.SaveChangesAsync();

            await reviewService.GetProductReviews(product.Id);


            var result = await dbContext.Reviews.Where(p=>p.ProductId==product.Id).Include(u=>u.User).ToListAsync();

            Assert.Equal(2,result.Count());
            Assert.NotNull(result.Count());

        }

        [Fact]
        public async void TestDeleteProductReviews()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("testdgewtrgfdsr46");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var repo = new Repository(dbContext);

            var reviewService = new ReviewService(dbContext, repo);
            var product = new Product()
            {
                Id = 1,
                Name = "product",
                Description = "description",
                Price = 10,
                Image = "image.jpg",
                CategoryId = 1
            };
            var user = new AppUser()
            {
                Id = "12345",
                UserName = "User1"
            };

            ReviewViewModel newReview = new ReviewViewModel()
            {
                Id = 3,
                Text = "Very good product",
                UserId = user.Id,
                User=user.UserName,
               ProductId=product.Id,
                CreatedOn = DateTime.Now
            };
            ReviewViewModel newReview2 = new ReviewViewModel()
            {
                Id = 4,
                Text = "Very good product",
                UserId = user.Id,
                User = user.UserName,
               ProductId=product.Id,
                CreatedOn = DateTime.Now
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.Products.AddAsync(product);

            reviewService.AddReview(newReview, user.Id);
            reviewService.AddReview(newReview2, user.Id);

            await dbContext.SaveChangesAsync();
            int reviewId = newReview.Id;

            await reviewService.DeleteReview(reviewId);

            var result = await dbContext.Reviews.ToListAsync();

            Assert.Equal(1, result.Count());
            Assert.NotNull(result.Count());

        }
    }
}
