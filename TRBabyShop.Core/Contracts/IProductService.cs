﻿using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetProductAsync();
        Task<IEnumerable<ProductViewModel>> GetProductsByCategoryAsync(int categoryId);
        Task AddProductAsync(AddProductViewModel model);

        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<Product> GetProductUpdateAsync(int id);
        Task UpdateProductAsync(int productId, ProductViewModel model);

        Task DeleteProduct(int productId);

        Task <ProductViewModel> GetProductById(int productId);
    }
}
