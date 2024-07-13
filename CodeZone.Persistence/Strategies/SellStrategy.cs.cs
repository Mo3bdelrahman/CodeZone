using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;

namespace CodeZone.Persistence.Strategies
{
    public class SellStrategy : IProcessStrategy
    {
        private readonly IStoreItemRepository _repository;

        public SellStrategy(IStoreItemRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> ProcessStoreItem(StoreItem storeItemRequest)
        {
            var storeItem = await _repository.GetStoreItem(storeItemRequest.StoreId, storeItemRequest.ItemId);
            if (storeItem.Quantity < storeItemRequest.Quantity)
                return false;

            storeItem.Quantity -= storeItemRequest.Quantity;
            return await _repository.Update(storeItem!);

        }
    }
}
