using Microsoft.EntityFrameworkCore;
using productMicroservice.Data;
using productMicroservice.Data.Repository;
using productMicroservice.Services;

namespace productMicroservice.IoC.IoCTest
{
    public static class IoCTest
    {
        public static IServiceCollection ConfigureInjectionDependencyRepositoryTest(this IServiceCollection services)
        {
            services.AddScoped<ProductRepository>();

            return services;
        }

        public static IServiceCollection ConfigureInjectionDependencyServiceTest(this IServiceCollection services)
        {
            services.AddScoped<ProductService>();

            return services;
        }
        public static IServiceCollection ConfigureDBContextTest(this IServiceCollection services)
        {
            services.AddDbContext<DbContextClass>(options =>
                options.UseInMemoryDatabase(databaseName: "TestApplication")
            );

            return services;
        }
    }
}
