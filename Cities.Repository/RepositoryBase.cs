using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Cities.Contracts;
using Cities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cities.Repository
{
    public abstract class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {
        protected CitiesDbContext Context { get; set; }

        protected RepositoryBase(CitiesDbContext context)
        {
            Context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.Context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return await this.Context.Set<T>().Where(expression).ToListAsync();
        }

        public void Create(T entity)
        {
            this.Context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.Context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.Context.Set<T>().Remove(entity);
        }

        public async Task SaveChanges()
        {
            await this.Context.SaveChangesAsync();
        }
    }
}
