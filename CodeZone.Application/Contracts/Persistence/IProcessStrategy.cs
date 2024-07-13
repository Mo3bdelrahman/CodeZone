using CodeZone.Domain.Entities;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IProcessStrategy
    {
        Task<bool> ProcessStoreItem(StoreItem storeItem);
    }
}
