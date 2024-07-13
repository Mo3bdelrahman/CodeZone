using CodeZone.Domain.Entities;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IStoreItemRepository : IRepository<StoreItem>
    {
        public Task<StoreItem?> GetStoreItem(int storeId, int itemId);
    }
}
