using Havas.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Data.IRepositories
{
    public interface IGenericRepository<T> : IDisposable
        where T : Auditable 
    {
        Task SaveAsync();
        Task<T> CreateAsync(T entity);
        T Update(T entity);
        Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

         
    }
}
