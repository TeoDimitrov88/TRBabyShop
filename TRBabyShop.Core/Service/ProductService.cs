using Microsoft.EntityFrameworkCore;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;

namespace TRBabyShop.Core.Service
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext dbContext;

        public ProductService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductAsync()
        {
            var products = await dbContext.Products
                .ToListAsync();

            return products
                .Select(p => new ProductViewModel()
                {
                    Name = p.Name,
                    Description= p.Description,
                    Category= p.Category,
                    Price = p.Price,
                    Image= p.Image,
                    Reviews= p.Reviews

                });
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await dbContext.Products.ToListAsync();

            return products
                 .Where(p => p.CategoryId == categoryId)
                 .Select(p => new ProductViewModel()
                 {
                     Name = p.Name,
                     Price = p.Price,
                     Image = p.Image,
                     Id=p.CategoryId
                 });

        }
    }
}
