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
    public class StoreRepository : BaseRepository<Store> ,IStoreRepository
    {
        public StoreRepository(CodeZoneContext context): base(context) { }

        public async Task<Store?> GetStoreByIdWithItems(int id)
        {
           return await _context.Stores.Include(e => e.Items).FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
