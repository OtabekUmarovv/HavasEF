using Havas.Domain.Entities.Suppleirs;
using Havas.Service.DTOs.SuppleirDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.Interfaces
{
    public interface ISuppleirService
    {
        Task<Suppleir> CreateAsync(SuppleirCreation model);
        Task<Suppleir> UpdateAsync(Guid Id, SuppleirCreation model);
        Task<Suppleir> GetAsync(Expression<Func<Suppleir, bool>> expression);
        Task<bool> DeleteAsync(Expression<Func<Suppleir, bool>> expression);
        Task<IEnumerable<Suppleir>> GetAllAsync(int pageIndex, int pageSize, Expression<Func<Suppleir, bool>> expression = null);
        Task<IEnumerable<Suppleir>> GetAllAsync(Expression<Func<Suppleir, bool>> expression = null);
    }
}
