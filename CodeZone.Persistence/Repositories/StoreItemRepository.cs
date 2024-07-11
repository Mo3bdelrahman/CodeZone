using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using CodeZone.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Persistence.Repositories
{
    public class StoreItemRepository : BaseRepository<StoreItem>, IStoreItemRepository
    {
        public StoreItemRepository(CodeZoneContext context) :base(context) { }
        public async Task<StoreItem?> GetStoreItem(int storeId, int itemId)
        {
            return await _context.StoresItems.FirstOrDefaultAsync(e => e.StoreId == storeId && e.ItemId == itemId);
        }
    }
}
