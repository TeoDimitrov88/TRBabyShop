using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Models;
using TRBabyShop.Core.Service;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Tests
{
    public class ShoppingCartServiceTests
    {
        Product product = new Product()
        {
            Id = 1,
            Name = "Product",
            Description = "Description",
            Price = 10,
            Image = "image.jpg",
            CategoryId = 1,
            Category = new Category() { Id = 1, Name = "Category" }
        };
        AppUser user = new AppUser()
        {
            Id = "12345",
            UserName = "User1"
        };
        ShoppingCart cart = new ShoppingCart()
        {
            Id = 1,
            User = new AppUser() { Id = "12345", UserName = "User1" },
            Product = new Product()
            {
                Id = 1,
                Name = "Product",
                Description = "Description",
                Price = 10,
                Image = "image.jpg",
                CategoryId = 1,
                Category = new Category() { Id = 1, Name = "Category" }
            },
            Price = 10,
            Quantity = 5,
            ProductId = 1
        };

        [Fact]
        public async void TestIncreaseCount()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test3");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var shoppingService=new ShoppingCartService(dbContext);

            shoppingService.IncreaseCount(cart, 1);

            Assert.Equal(6, cart.Quantity);
        }

        [Fact]
        public async void TestDecreaseCount()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test3");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var shoppingService = new ShoppingCartService(dbContext);
            shoppingService.DecreaseCount(cart, 4);

            Assert.Equal(1, cart.Quantity);
        }
    }
}
