using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace newbackend.Installer
{
    public interface IInstaller
    {
         void InstallServices(IServiceCollection service, IConfiguration configuration);
    }
}