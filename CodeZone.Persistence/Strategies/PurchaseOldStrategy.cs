using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Persistence.Strategies
{
    public class PurchaseOldStrategy : IProcessStrategy
    {
        private readonly IStoreItemRepository _repository;

        public PurchaseOldStrategy(IStoreItemRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> ProcessStoreItem(StoreItem storeItemRequest)
        {
            var storeItem = await _repository.GetStoreItem(storeItemRequest.StoreId,storeItemRequest.ItemId);
            storeItem.Quantity += storeItemRequest.Quantity;
            return await _repository.Update(storeItem!);
        }
    }
}
