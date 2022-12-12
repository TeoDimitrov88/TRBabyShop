using Microsoft.EntityFrameworkCore;
using TRBabyShop.Core.Models;
using TRBabyShop.Core.Service;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Tests
{
    public class CategoryTests
    {
        Category category = new Category()
        {
            Id = 5,
            Name="Something"
        };
        Category category2 = new Category()
        {
            Id=6,
            Name="New Category" 
        };

        [Fact]
        public async void AddNewCategory()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test");
            var dbContext=new ApplicationDbContext(optionBuilder.Options);

            var categoryService=new CategoryService(dbContext);

            CategoryViewModel newCategory = new CategoryViewModel()
            {
                Name="Bottles"
            };

            await categoryService.AddCategoryAsync(newCategory);

            var result= dbContext.Categories.Where(c=>c.Name==newCategory.Name).FirstOrDefault();

            Assert.Equal("Bottles", result.Name);
        }

        [Fact]
        public async void DeleteCategory()
        {
            var optioBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("test1");

            var dbContext=new ApplicationDbContext(optioBuilder.Options);

            var categoryService = new CategoryService(dbContext);

            dbContext.Add(category);
            dbContext.Add(category2);

            dbContext.SaveChanges();

            var result = dbContext.Categories.ToList();

            Assert.Equal(2, result.Count);

            await categoryService.DeleteCategory(5);

            result=dbContext.Categories.ToList();

            Assert.Equal(1,result.Count);
        }

        [Fact]
        public async void GetAllCategories()
        {
            var optioBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase("test2");

            var dbContext = new ApplicationDbContext(optioBuilder.Options);

            var categoryService = new CategoryService(dbContext);

            dbContext.Add(category);
            dbContext.Add(category2);

            dbContext.SaveChanges();

            var result=await categoryService.GetCategoriesAsync();

            Assert.Equal(2, result.Count());
        }
    }
}