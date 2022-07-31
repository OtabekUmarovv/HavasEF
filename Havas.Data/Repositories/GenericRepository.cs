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



        public async Task<T> CreateAsync(T entity)
            => (await _dbSet.AddAsync(entity)).Entity;

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(expression);

            if (entity is null)
                return false;

            _dbSet.Remove(entity);

            return true;
        }


        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
            => expression is null ? _dbSet : _dbSet.Where(expression);


        public Task<T?> GetAsync(Expression<Func<T, bool>> expression)
            => _dbSet.FirstOrDefaultAsync(expression);

        public Task SaveChangesAsync() => _context.SaveChangesAsync();
        
        public void Dispose() => GC.SuppressFinalize(this);

        public T Update(T entity)
            => _dbSet.Update(entity).Entity;
    }
}
