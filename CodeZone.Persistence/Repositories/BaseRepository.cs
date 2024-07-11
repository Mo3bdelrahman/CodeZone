using CodeZone.Application.Contracts.Persistence;
using CodeZone.Persistence.Data;
using Microsoft.EntityFrameworkCore;


namespace CodeZone.Persistence.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly CodeZoneContext _context;
        public BaseRepository(CodeZoneContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<T?> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<bool> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
