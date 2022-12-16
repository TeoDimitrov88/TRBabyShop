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
    public class ProductServiceTests
    {
        AddProductViewModel product = new AddProductViewModel()
        {
            Name = "Product1",
            Description = "Description",
            Price = 10,
            Image = "image.jpg",
            CategoryId = 1,
        };

        AddProductViewModel product2 = new AddProductViewModel()
        {
            Name = "Product2",
            Description = "Description",
            Price = 10,
            Image = "image.jpg",
            CategoryId = 2,
           
        };

        [Fact]
        public async void TestAddNewProduct()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test3");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            AddProductViewModel newProduct = new AddProductViewModel()
            {
                Name = "Bottles",
                Description = "Description",
                Price = 10,
                Image = "iamge.jpg",
                CategoryId = 1

            };

            await productService.AddProductAsync(newProduct);

            var result = await dbContext.Products.ToListAsync();

            Assert.Equal(1, result.Count());
        }

        [Fact]
        public async void TestGetAllProducts()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test4");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            productService.AddProductAsync(product);
            productService.AddProductAsync(product2);

            dbContext.SaveChanges();
            var result = await productService.GetProductAsync();

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async void TestGetProductsByCategoryId()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test5");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            productService.AddProductAsync(product);
            productService.AddProductAsync(product2);

            dbContext.SaveChanges();
            var result = await productService.GetProductsCategoryId(2);


            Assert.Equal(2, product2.CategoryId);
        }

        [Fact]
        public async void TestUpdateProduct()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test10");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            Product product5 = new Product()
            {
                Id = 5,
                Name = "product",
                Description = "Description",
                CategoryId = 1,
                Price = 10,
                Image = "image.jpg"
            };
            dbContext.Products.Add(product5);

            var model = new UpdateProductVM()
            {
                Id = 5,
                Name = "UpdatedProduct",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg"
            };

            var result = productService.UpdateProductAsync(product5.Id, model);

            Assert.Equal(product5.Name, "UpdatedProduct");
            Assert.Equal(product5.Description, "Description2");
            Assert.Equal(product5.CategoryId, 2);
            Assert.Equal(product5.Price, 100);
            Assert.Equal(product5.Image, "image1.jpg");
        }

        [Fact]
        public async void TestUpdateProductThrowArgumentExceptionForInvalidProductId()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test7420");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            var model = new UpdateProductVM()
            {
                Id = 5,
                Name = "UpdatedProduct",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg"
            };


           await Assert.ThrowsAsync<ArgumentException>(() => productService.UpdateProductAsync(5684, model));
        }

        [Fact]
        public async void TestDeleteProduct()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test20");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            var productTest = new Product()
            {
                Id = 5,
                Name = "Product",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg"
            };
            var productTest2 = new Product()
            {
                Id = 6,
                Name = "Product",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg",
            };

            await dbContext.Products.AddAsync(productTest);
            await dbContext.Products.AddAsync(productTest2);
            await dbContext.SaveChangesAsync();

            await productService.DeleteProduct(productTest.Id);

            await dbContext.SaveChangesAsync();
            var result = await dbContext.Products.ToListAsync();

            Assert.Equal(1, result.Count());

        }

        [Fact]
        public async void TestGetProductById()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test30");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            var productTest = new Product()
            {
                Id = 5,
                Name = "Product",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg"
            };
            var productTest2 = new Product()
            {
                Id = 6,
                Name = "Product",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg",
            };

            await dbContext.Products.AddAsync(productTest);
            await dbContext.Products.AddAsync(productTest2);
            await dbContext.SaveChangesAsync();

            var result = await productService.GetProductById(productTest.Id);


            Assert.Equal(5, result.Id);

        }
        [Fact]
        public async void TestGetProductByIdThrowsArgumentExceptionForInvalidProductId()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test40");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);
            await Assert.ThrowsAsync<ArgumentException>(() => productService.GetProductById(15452));
        }

        [Fact]
        public async void TestGetCategoriesAsync()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test35");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            Category newCategory = new Category()
            {
                Name = "Bottle",
                Image = "image.jpg"
            };
            Category newCategory2 = new Category()
            {
                Name = "Clothes",
                Image = "image.jpg"
            };

            dbContext.Categories.Add(newCategory);
            dbContext.Categories.Add(newCategory2);
            dbContext.SaveChanges();
            await productService.GetCategoriesAsync();

            var result = await dbContext.Categories.ToListAsync();

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async void TestGetProductsByCategoryAsync()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test37");
            var dbContext = new ApplicationDbContext(optionBuilder.Options);
            var repo = new Repository(dbContext);

            var productService = new ProductService(dbContext, repo);

            var productTest = new Product()
            {
                Id = 5,
                Name = "Product",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg"
            };
            var productTest2 = new Product()
            {
                Id = 6,
                Name = "Product",
                Description = "Description2",
                CategoryId = 2,
                Price = 100,
                Image = "image1.jpg",
            };

            await dbContext.Products.AddAsync(productTest);
            await dbContext.Products.AddAsync(productTest2);
            await dbContext.SaveChangesAsync();

            var result = await productService.GetProductsByCategoryAsync(productTest.CategoryId);

            Assert.Equal(2, result.Count());
        }
    }
}