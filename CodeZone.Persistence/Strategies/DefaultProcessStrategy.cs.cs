using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;

namespace CodeZone.Persistence.Strategies
{
    public class DefaultProcessStrategy : IProcessStrategy
    {
        public Task<bool> ProcessStoreItem(StoreItem storeItem)
        {
            return Task.FromResult(true);
        }
    }
}
