using ProiectTest.CategoryRepositoryy;
using ProiectTest.Helper.Seeders;
using ProiectTest.ProductRepositoryy;
using ProiectTest.Services.CategoryService;
using ProiectTest.Services.ProductService;

namespace ProiectTest.Helper.Externsions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddScoped<CategorySeeder>();
            return services;
        }
    }
}