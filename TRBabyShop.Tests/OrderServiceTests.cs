using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Service;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;
using static TRBabyShop.Infrastructure.Data.Common.Constants;

namespace TRBabyShop.Tests
{
    public class OrderServiceTests
    {
        AppUser user = new AppUser()
        {
            Id="12345",
            UserName="User123",
            Email="user@abv.bg"
        };
        Order order = new Order()
        {
            Id = 1,
            UserId="12345",
            Name="User123",
            Email="user@abv.bg",
            City="Varna",
            PostCode="9000",
            PaymentStatus=Status.ApprovedStatus,
            OrderStatus=Status.ApprovedStatus,
            OrderDate=DateTime.Now,
            OrderTotal=100,
            SessionId="12356789",
            PaymentIntentId="1"
        };

        [Fact]
        public async void TestGetOrder()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseInMemoryDatabase("test3d43565");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var orderService = new OrderService(dbContext);
            dbContext.Users.Add(user);
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();

           var result= await orderService.GetOrderAsync();

            Assert.Equal(1, result.Count());
            Assert.NotNull(order);
        }

        [Fact]
        public async void TestUpdateOrder()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseInMemoryDatabase("test3d43");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var orderService = new OrderService(dbContext);
            dbContext.Users.Add(user);
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();

            order.City = "Sofia";
            order.PostCode = "5500";

            orderService.Update(order);

            Assert.Equal("Sofia", order.City);
            Assert.Equal("5500",order.PostCode);
        }

        [Fact]
        public async void TestUpdateStatusOrder()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseInMemoryDatabase("tes43");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var orderService = new OrderService(dbContext);
            dbContext.Users.Add(user);
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();

            string orderStatus = "Pending";
            string paymentStatus = "Pending";

            orderService.UpdateStatus(order.Id,orderStatus,paymentStatus);

            Assert.Equal("Pending", order.OrderStatus);
            Assert.Equal("Pending", order.PaymentStatus);
        }

        [Fact]
        public async void TestUpdateStripePaymentId()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseInMemoryDatabase("tes434ht5ht");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var orderService = new OrderService(dbContext);
            dbContext.Users.Add(user);
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();

            string sessionId = "452765427547";
            string paymentIntentId = "fgjy4jjgfj3";

            orderService.UpdateStripePaymentId(order.Id, sessionId, paymentIntentId);

            Assert.Equal("452765427547", order.SessionId);
            Assert.Equal("fgjy4jjgfj3", order.PaymentIntentId);
        }
    }
}
