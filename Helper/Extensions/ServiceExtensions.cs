using ProiectTest.ProductRepositoryy;
using ProiectTest.Services.DemoService;

namespace ProiectTest.Helper.Externsions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDemoService, DemoService>();
            return services;
        }
    }
}