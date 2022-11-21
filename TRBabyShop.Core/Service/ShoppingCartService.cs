
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Models;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Service
{
    public class ShoppingCartService:IShoppingCartService
    {
        private readonly ApplicationDbContext dbContext;

       
        public ShoppingCartService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        
        public int DecreaseCount(ShoppingCart shoppingCart, int quantity)
        {
            shoppingCart.Quantity -= quantity;
            return shoppingCart.Quantity;
        }

        public int IncreaseCount(ShoppingCart shoppingCart, int quantity)
        {
            shoppingCart.Quantity += quantity;
            return shoppingCart.Quantity;
        }

        
    }
}
