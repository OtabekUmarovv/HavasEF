using Havas.Domain.Commons;
using Havas.Domain.Entities.Suppleirs;
using Havas.Service.DTOs.SuppleirDTOs;
using Havas.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.Services
{
    public class SuppleirService : ISuppleirService
    {
        public Task<BaseResponse<Suppleir>> CreateAsync(SuppleirForCreationDto model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Suppleir, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Suppleir>>> GetAllAsync(Expression<Func<Suppleir, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Suppleir>>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Suppleir, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Suppleir>> GetAsync(Expression<Func<Suppleir, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Suppleir>> Update(SuppleirForCreationDto model)
        {
            throw new NotImplementedException();
        }
    }
}
