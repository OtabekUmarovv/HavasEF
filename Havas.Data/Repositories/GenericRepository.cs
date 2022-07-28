using Havas.Data.Contexts;
using Havas.Data.IRepositories;
using Havas.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        protected readonly HavasDBContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository()
        {
            this._dbContext = new HavasDBContext();
            this._dbSet = _dbContext.Set<T>();
        }

        public void Dispose() => GC.SuppressFinalize(this);

        public Task SaveAsync => this._dbContext.SaveChangesAsync();


        public Task<bool> Delete(Expression<Func<T, bool>> expression)
        { 
            var entity = this.GetAsync(expression);

            if (entity is null)
                return false;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
