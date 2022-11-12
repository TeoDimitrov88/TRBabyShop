
using TRBabyShop.Core.Contracts;
using TRBabyShop.Infrastructure.Data;
using TRBabyShop.Infrastructure.Data.Common;

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
    }
}
