
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Service;
using TRBabyShop.Infrastructure.Data.Common;

namespace TRBabyShop.Extensions
{
    public static class TRBabyShopServiceCollection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
