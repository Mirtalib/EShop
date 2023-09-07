using EShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEnitity
    {
        IEnumerable<T?> GetAll(bool tracking = true);
        IEnumerable<T?> GetWhere(Expression<Func<T, bool>> expression);

        Task<T?> GetAsync(string id);
        Task<T?> GetAsync(Expression<Func<T, bool>> expression);

    }
}
