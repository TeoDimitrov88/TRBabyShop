using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Core.Contracts
{
    public interface IShoppingCartService
    {
       int DecreaseCount(ShoppingCart shoppingCart, int count);

       int IncreaseCount(ShoppingCart shoppingCart, int count);
    }
}
