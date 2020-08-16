using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace newbackend.Installer
{
    public class JsonInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddNewtonsoftJson();
        }

    }
}