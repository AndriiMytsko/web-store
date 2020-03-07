using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Bll;

namespace WebStore.WebApi.Infrastructure.ServiceExtensions
{
    public static class MapperServiceExtensions
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BllMappingProfile>();
                cfg.AddProfile<MappingProfile>();
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
