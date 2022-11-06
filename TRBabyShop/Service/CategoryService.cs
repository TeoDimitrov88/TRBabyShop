using Microsoft.EntityFrameworkCore;
using TRBabyShop.Contracts;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;
using TRBabyShop.Models;

namespace TRBabyShop.Service
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
                    Name = c.Name

                });
        }
    }
}
