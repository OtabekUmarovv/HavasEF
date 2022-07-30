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
        Task<BaseResponse<Suppleir>> CreateAsync(SuppleirCreation model);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Suppleir, bool>> expression);
        Task<BaseResponse<Suppleir>> Update(SuppleirCreation model);
        Task<BaseResponse<Suppleir>> GetAsync(Expression<Func<Suppleir, bool>> expression);
        Task<BaseResponse<IEnumerable<Suppleir>>> GetAllAsync(Expression<Func<Suppleir, bool>>? expression = null);
        Task<BaseResponse<IEnumerable<Suppleir>>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Suppleir, bool>>? expression = null); 
    }
}
