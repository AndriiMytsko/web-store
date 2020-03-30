using Microsoft.Extensions.DependencyInjection;
using WebStore.Dal.Configs;
using WebStore.Dal.Repositories;
using WebStore.Dal.Repositories.Interfaces;
using WebStore.Dal.Providers;
//using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;

namespace WebStore.WebApi.Infrastructure.ServiceExtensions
{
    public static class DalServiceExtensions
    {
        public static IServiceCollection AddDal(this IServiceCollection services, ConnectionSettings connectionSettings, IWebHostEnvironment env)
        {
            services.AddSingleton(connectionSettings);
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderDetailsRepository, OrderDetailsRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IFileProvider, FileProvider>(x => new FileProvider(env.ContentRootPath));

            return services;
        }
    }
}
