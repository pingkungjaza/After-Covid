using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using newbackend.Data;
using newbackend.Services;

namespace newbackend.Installer
{
    public class DatabaseInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("ConnectionSQLServer")));

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();
        }
    }
}