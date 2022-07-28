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
        protected readonly HavasDBContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository()
        {
            _context = new HavasDBContext();
            _dbSet = _context.Set<T>();
        }

        public virtual Task<T> CreateAsync(T entity) =>
             Task.FromResult(this._dbSet.Add(entity).Entity);

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await GetAsync(expression);

            if(entity is null)
                return false;

            _dbSet.Remove(entity);

            return true;
        }

        public void Dispose() => GC.SuppressFinalize(this);



        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression) =>
            expression is null ? _dbSet : _dbSet.Where(expression);
        

        public Task<T> GetAsync(Expression<Func<T, bool>> expression) =>
            this._dbSet.FirstOrDefaultAsync(expression);

        public Task SaveAsync() => this._context.SaveChangesAsync();

        public T Update(T entity) =>
            this._dbSet.Update(entity).Entity;
    }
}
