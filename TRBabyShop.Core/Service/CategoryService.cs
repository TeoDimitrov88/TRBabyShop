using Microsoft.EntityFrameworkCore;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync()
        {
            var categories = await dbContext.Categories
                .ToListAsync();

            return categories
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name

                });
        }

        public async Task AddCategoryAsync(CategoryViewModel model)
        {
            var newCategory = new Category()
            {
                Id = model.Id,
                Name = model.Name,
               
            };

            await dbContext.Categories.AddAsync(newCategory);
            await dbContext.SaveChangesAsync();
        }
    }
}
