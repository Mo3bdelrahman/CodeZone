using CodeZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IStoreItemRepository : IRepository<StoreItem>
    {
        public Task<StoreItem?> GetStoreItem(int storeId, int itemId);
    }
}
