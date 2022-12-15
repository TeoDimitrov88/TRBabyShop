using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetProductAsync();
        Task<IEnumerable<ProductViewModel>> GetProductsByCategoryAsync(int categoryId);
        Task AddProductAsync(AddProductViewModel model);

        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<int> GetProductsCategoryId(int productId);

        Task UpdateProductAsync(int productId, UpdateProductVM model);

        Task DeleteProduct(int productId);

        Task <ProductViewModel> GetProductById(int productId);

        Task<IEnumerable<ProductViewModel>> GetProductWithMostReviews();
    }
}
