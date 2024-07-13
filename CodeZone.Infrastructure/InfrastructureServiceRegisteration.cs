using CodeZone.Application.Contracts.Infrastructure;
using CodeZone.Infrastructure.ImageService;
using Microsoft.Extensions.DependencyInjection;

namespace CodeZone.Infrastructure
{
    public static class InfrastructureServiceRegisteration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IImageService, ImageToLocalService>();

            return services;
        }
    }
}
