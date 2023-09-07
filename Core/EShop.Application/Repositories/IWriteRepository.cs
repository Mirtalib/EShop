using EShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEnitity
    {
        Task<bool> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        bool Update(T entity);
        bool Remove(T entity);

        Task<bool> RemoveAsync(string id);

        Task<int> SaveChangesAsync();
    }
}
