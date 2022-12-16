using Microsoft.EntityFrameworkCore;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
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
                    Name = c.Name,
                    Image=c.Image

                });
        }

        public async Task AddCategoryAsync(CategoryViewModel model)
        {
            var newCategory = new Category()
            {
                Name = model.Name,
               Image = model.Image,
            };

            await dbContext.Categories.AddAsync(newCategory);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteCategory(int categoryId)
        {
            var category= await dbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);

             dbContext.Categories.Remove(category!);

            await dbContext.SaveChangesAsync();
        }
    }
}
