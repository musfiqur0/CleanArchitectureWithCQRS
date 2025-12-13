using CleanArchitectureWithCQRS.Domain.Repository;
using CleanArchitectureWithCQRS.Infrastructure.Data;
using CleanArchitectureWithCQRS.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureWithCQRS.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("BlogDbContext") ??
                throw new InvalidOperationException("Connection string 'BlogDbContext' not found."))
            );

            services.AddTransient<IBlogRepository, BlogRepository>();

            return services;
        }
    }
}
