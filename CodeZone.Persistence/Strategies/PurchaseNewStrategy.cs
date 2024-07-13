using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;

namespace CodeZone.Persistence.Strategies
{
    public class PurchaseNewStrategy : IProcessStrategy
    {
        private readonly IStoreItemRepository _repository;

        public PurchaseNewStrategy(IStoreItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> ProcessStoreItem(StoreItem storeItemRequest)
        {
            return await _repository.Add(storeItemRequest);
        }
    }
}
