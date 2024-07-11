using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CodeZone.Persistence.Data;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Persistence.Repositories;

namespace CodeZone.Persistence
{
    public static class PersistenceServiceResgistration
    {
        public static IServiceCollection AddPersistanceService(this IServiceCollection services, IConfiguration configuration)
        {
            //add dbcontext and repositories 
            services.AddDbContext<CodeZoneContext>(options =>
            {
                options.UseSqlServer(configuration["DbConnection"]);
            });

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IStoreItemRepository, StoreItemRepository>();

            return services;
        }
    }
}
