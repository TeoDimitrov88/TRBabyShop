using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Core.Contracts;
using TRBabyShop.Infrastructure.Data;

namespace TRBabyShop.Core.Service
{
    public class ShoppingCartService:IShoppingCartService
    {
        private readonly ApplicationDbContext dbContext;

        public ShoppingCartService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
    }
}
