using TRBabyShop.Core.Models;


namespace TRBabyShop.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();
    }
}
