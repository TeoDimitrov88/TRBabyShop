using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Models;

namespace TRBabyShop.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<ProductQueryModel>> GetFavoriteProductForUsersAsync(string userId);

        Task AddProductToUserCollectionAsync(int productId, string userId);

        Task RemoveProductFromFavoriteAsync(int productId, string userId);

    }
}
