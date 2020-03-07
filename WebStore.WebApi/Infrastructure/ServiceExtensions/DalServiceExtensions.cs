using Microsoft.Extensions.DependencyInjection;
using WebStore.Dal.Configs;
using WebStore.Dal.Repositories;
using WebStore.Dal.Repositories.Interfaces;

namespace WebStore.WebApi.Infrastructure.ServiceExtensions
{
    public static class DalServiceExtensions
    {
        public static IServiceCollection AddDal(this IServiceCollection services, ConnectionSettings connectionSettings)
        {
            services.AddSingleton(connectionSettings);
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderDetailsRepository, OrderDetailsRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
