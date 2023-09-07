using EShop.Application.Repositories;
using EShop.Domain.Entities.Common;
using EShop.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEnitity
    {
        private readonly EShopDbContext context;

        public ReadRepository(EShopDbContext context)
        {
            this.context = context;
        }

        DbSet<T> Table => context.Set<T>();

        public IEnumerable<T?> GetAll(bool tracking = true)
        {
            if (tracking)
                return Table.ToList();
            //var query = Table.AsNoTracking();
            //query.FirstOrDefault();
            return Table.AsNoTracking().ToList();
        }

        public async Task<T?> GetAsync(string id)
            //=> await Table.FindAsync(Guid.Parse(id));
            => await Table.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));

        public async Task<T?> GetAsync(Expression<Func<T, bool>> expression)
            => await Table.FirstOrDefaultAsync(expression);

        public IEnumerable<T?> GetWhere(Expression<Func<T, bool>> expression)
            => Table.Where(expression);
    }
}
