using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;
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

        
        public int DecreaseCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Quantity -= count;
            return shoppingCart.Quantity;
        }

        public int IncreaseCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Quantity += count;
            return shoppingCart.Quantity;
        }
    }
}
