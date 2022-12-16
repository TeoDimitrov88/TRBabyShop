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
    public class UserServiceTests
    {
        Product product = new Product()
        {
            Id = 1,
            Name = "Product",
            Description = "Description",
            Price = 10,
            Image = "image.jpg",
            CategoryId = 1,
            Category = new Category() { Id = 1, Name = "Category" , Image = "image1.jpg" }
        };
        AppUser user = new AppUser()
        {
            Id = "12345",
            UserName = "User1"
        };
        UserProduct userProduct = new UserProduct()
        {
            UserId = "12345",
            ProductId = 1,
        };

        [Fact]
        public async void TestGetFavoriteProductForUsers()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test80");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);
           

            dbContext.Users.Add(user);
            dbContext.Products.Add(product);
            user.UserProducts.Add(userProduct);
            dbContext.SaveChanges();

            var result=await userService.GetFavoriteProductForUsersAsync(user.Id);

           

            Assert.Equal(1,result.Count());
        }

        [Fact]
        public async void TestGetFavoriteProductForUsersThrowsArgumetnExceptionForInvalidUser()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test71");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);
           

            dbContext.Users.Add(user);
            dbContext.Products.Add(product);
            user.UserProducts.Add(userProduct);
            dbContext.SaveChanges();

            await Assert.ThrowsAsync<ArgumentException>(()=>  userService.GetFavoriteProductForUsersAsync("123rrfsv"));
        }

        [Fact]
        public async void TestRemoveFavoriteProductForUsers()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test69");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);
           

            dbContext.Users.Add(user);
            dbContext.Products.Add(product);
            user.UserProducts.Add(userProduct);
            dbContext.SaveChanges();

            await userService.RemoveProductFromFavoriteAsync(product.Id, user.Id);

            var result=dbContext.UserProducts.Where(u=>u.UserId == user.Id).ToList();

            Assert.Equal(0, result.Count);
        }

        [Fact]
        public async void TestRemoveFavoriteProductThrowsArgumetnExceptionForInvalidUser()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test68");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);
           

            dbContext.Users.Add(user);
            dbContext.Products.Add(product);
            user.UserProducts.Add(userProduct);
            dbContext.SaveChanges();

            await Assert.ThrowsAsync<ArgumentException>(() => userService.RemoveProductFromFavoriteAsync(product.Id,"123rrfsv"));

        }

        [Fact]
        public async void TestRemoveFavoriteProductThrowsArgumetnExceptionForInvalidProduct()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test66");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);
            

            dbContext.Users.Add(user);
            dbContext.Products.Add(product);
            user.UserProducts.Add(userProduct);
            dbContext.SaveChanges();

            await Assert.ThrowsAsync<ArgumentException>(() => userService.RemoveProductFromFavoriteAsync(1578745, user.Id));

        }

        [Fact]
        public async void TestAddProductToUserCollection()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test619");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);
           

            dbContext.Users.Add(user);
            dbContext.Products.Add(product);
            
            dbContext.SaveChanges();

            await userService.AddProductToUserCollectionAsync(product.Id, user.Id);

            var result = dbContext.UserProducts.Where(u => u.UserId == user.Id).ToList();

            Assert.Equal(1, result.Count);
        }

        [Fact]
        public async void TestAddProductToUserCollectionThrowsArgumentExceptionForInvalidUser()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test679");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);


            dbContext.Users.Add(user);
            dbContext.Products.Add(product);

            dbContext.SaveChanges();

            await Assert.ThrowsAsync<ArgumentException>(() => userService.AddProductToUserCollectionAsync(product.Id, "31453hfhsf"));
        }

        [Fact]
        public async void TestAddProductToUserCollectionThrowsArgumentExceptionForInvalidProduct()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test345679019");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);


            dbContext.Users.Add(user);
            dbContext.Products.Add(product);

            dbContext.SaveChanges();

            await Assert.ThrowsAsync<ArgumentException>(() => userService.AddProductToUserCollectionAsync(4687466, user.Id));
        }

        [Fact]
        public async void TestAddProductToUserCollectionThrowsArgumentExceptionForAlreadyAddedProduct()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test67819");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var userService = new UserService(dbContext, repo);

            dbContext.Users.Add(user);
            dbContext.Products.Add(product);
            user.UserProducts.Add(userProduct);

            dbContext.SaveChanges();

            await Assert.ThrowsAsync<ArgumentException>(() => userService.AddProductToUserCollectionAsync(product.Id, user.Id));
        }
    }
}
