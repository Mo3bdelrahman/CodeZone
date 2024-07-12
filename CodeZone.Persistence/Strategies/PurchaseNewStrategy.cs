using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
