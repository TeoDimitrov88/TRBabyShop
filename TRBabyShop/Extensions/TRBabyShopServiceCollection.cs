
using TRBabyShop.Core.Contracts;
using TRBabyShop.Core.Service;
using TRBabyShop.Infrastructure.Data.Common;

namespace TRBabyShop.Extensions
{
    public static class TRBabyShopServiceCollection
    {

        /// <summary>
        /// Collecting all Services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
