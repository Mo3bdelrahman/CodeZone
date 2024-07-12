using CodeZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IProcessStrategy
    {
        Task<bool> ProcessStoreItem(StoreItem storeItem);
    }
}
