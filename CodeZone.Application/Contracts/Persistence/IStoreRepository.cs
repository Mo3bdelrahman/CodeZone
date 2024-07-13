using CodeZone.Domain.Entities;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IStoreRepository : IRepository<Store>
    {
        Task<Store?> GetStoreByIdWithItems(int id);
    }
}
