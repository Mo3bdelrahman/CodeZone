using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetById(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
