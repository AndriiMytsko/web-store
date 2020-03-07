using Microsoft.Extensions.DependencyInjection;
using WebStore.Bll.Services;
using WebStore.Bll.Services.Interfaces;

namespace WebStore.WebApi.Infrastructure.ServiceExtensions
{
    public static class BllServiceExtensions
    {
        public static IServiceCollection AddBll(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderDetailsService, OrderDetailsService>();

            return services;
        }
    }
}
