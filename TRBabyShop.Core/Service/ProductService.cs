
using Microsoft.EntityFrameworkCore;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Service
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext dbContext;

        private readonly IRepository repo;

        public ProductService(ApplicationDbContext _dbContext, IRepository _repo)
        {
            repo = _repo;
            dbContext = _dbContext;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductAsync()
        {
            var products = await dbContext.Products
                .Include(r => r.Reviews)
                .ToListAsync();

            return products
                .Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    CategoryId = p.CategoryId,
                    Price = p.Price,
                    Image = p.Image,
                    Reviews = p.Reviews.ToList()
                });
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await repo.AllReadonly<Category>()
                .Select(c => new Category()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await dbContext.Products.ToListAsync();

            return products
                 .Where(p => p.CategoryId == categoryId)
                 .Select(p => new ProductViewModel()
                 {
                     CategoryId = p.CategoryId,
                     Name = p.Name,
                     Price = p.Price,
                     Image = p.Image,
                     Id = p.Id
                 });

        }

        public async Task AddProductAsync(AddProductViewModel model)
        {
            var newProduct = new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                Image = model.Image,
                CategoryId = model.CategoryId
            };

            await dbContext.Products.AddAsync(newProduct);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(int productId, UpdateProductVM model)
        {
            var product = await repo.GetByIdAsync<Product>(productId);

            if (product == null)
            {
                throw new ArgumentException("Wrong product ID!");
            }

            product.Name = model.Name;
            product.Price = model.Price;
            product.Description = model.Description;
            product.Image = model.Image;
            product.CategoryId = model.CategoryId;

            repo.Update(product);

            await repo.SaveChangesAsync();

        }

        public async Task DeleteProduct(int productId)
        {
            await repo.DeleteAsync<Product>(productId);
            await repo.SaveChangesAsync();
        }

        public async Task<int> GetProductsCategoryId(int productId)
        {
            return (await repo.GetByIdAsync<Product>(productId)).CategoryId;
        }

        public async Task<ProductViewModel> GetProductById(int productId)
        {
            var product = await repo.GetByIdAsync<Product>(productId);
            if (product == null)
            {
                throw new ArgumentException("Invalid product Id.");
            }

            return new ProductViewModel()
            {
                Name = product.Name,
                Description = product.Description,
                Id = product.Id,
                Price = product.Price,
                CategoryId = product.CategoryId,
                Image = product.Image,
                Reviews = product.Reviews

            };
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductWithMostReviews()
        {
            var products = await dbContext.Products
                .Include(r => r.Reviews)
                .OrderByDescending(r => r.Reviews.Count)
                .ToListAsync();

            return products
                .Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    CategoryId = p.CategoryId,
                    Price = p.Price,
                    Image = p.Image,
                    Reviews = p.Reviews.ToList()
                });
        }
    }
}
