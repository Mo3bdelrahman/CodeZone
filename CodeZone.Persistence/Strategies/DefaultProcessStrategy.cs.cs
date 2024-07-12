using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
