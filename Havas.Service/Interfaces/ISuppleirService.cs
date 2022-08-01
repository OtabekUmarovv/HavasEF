using Havas.Domain.Commons;
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
        Task<Suppleir> CreateAsync(SuppleirForCreationDto model);
        Task<bool> DeleteAsync(Expression<Func<Suppleir, bool>> expression);
        Task<Suppleir> Update(Guid id, SuppleirForCreationDto model);
        Task<Suppleir>  GetAsync(Expression<Func<Suppleir, bool>> expression);
        Task<IEnumerable<Suppleir>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Suppleir, bool>>? expression = null); 
    }
}
