
using Microsoft.Extensions.DependencyInjection;

namespace CodeZone.Application
{
    public static class ApplicationSerivceRegistration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            // add mappers,middelwares
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;

        }
    }
}
