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
        public Task<Suppleir> CreateAsync(SuppleirCreation model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Suppleir, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Suppleir>> GetAllAsync(int pageIndex, int pageSize, Expression<Func<Suppleir, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Suppleir>> GetAllAsync(Expression<Func<Suppleir, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Suppleir> GetAsync(Expression<Func<Suppleir, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Suppleir> UpdateAsync(Guid Id, SuppleirCreation model)
        {
            throw new NotImplementedException();
        }
    }
}
