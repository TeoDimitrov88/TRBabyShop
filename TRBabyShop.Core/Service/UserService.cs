
using Microsoft.EntityFrameworkCore;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Service
{
    public class UserService:IUserService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IRepository repo;

        public UserService(ApplicationDbContext _dbContext,IRepository _repo)
        {
            dbContext = _dbContext;
            repo = _repo;
        }

        public async Task<IEnumerable<ProductQueryModel>> GetFavoriteProductForUsersAsync(string userId)
        {
            var user = await dbContext.Users.Where(u => u.Id == userId)
                .Include(u => u.UserProducts)
                .ThenInclude(up => up.Product)
                .ThenInclude(p => p.Category)
                .FirstOrDefaultAsync();
            if (user == null)
            {
                throw new ArgumentException("Invalid user!");
            }

            return user.UserProducts.Select(u => new ProductQueryModel()
            {
                Id = u.ProductId,
                Name = u.Product.Name,
                Description = u.Product.Description,
                Price=u.Product.Price,
                Image = u.Product.Image,
                CategoryId = u.Product.CategoryId,
                Category=u.Product.Category.Name
            });
        }

        public async Task AddProductToUserCollectionAsync(int productId, string userId)
        {
            var user = await dbContext.Users.Where(u => u.Id == userId).Include(u => u.UserProducts).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new ArgumentException("Invalid User ID");
            }

            var product = await dbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
            {
                throw new ArgumentException("Invalid product Id");
            }

            if (!user.UserProducts.Any(p => p.ProductId == productId))
            {
                var productToAdd = new UserProduct()
                {
                    ProductId = product.Id,
                    UserId = user.Id
                };
               await  dbContext.UserProducts.AddAsync(productToAdd);
              await dbContext.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException("Product is already added to your favorites!");
            }
        }

        public async Task RemoveProductFromFavoriteAsync(int productId, string userId)
        {
            var user = await dbContext.Users.Where(u => u.Id == userId).Include(u => u.UserProducts).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user Id");
            }

            var product = user.UserProducts.FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
            {
                throw new ArgumentException("Invalid product Id");
            }
             dbContext.UserProducts.Remove(product);
            await dbContext.SaveChangesAsync();
        }
    }
}
