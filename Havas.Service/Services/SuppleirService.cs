using AutoMapper;
using Havas.Data.IRepositories;
using Havas.Data.Repositories;
using Havas.Domain.Commons;
using Havas.Domain.Entities.Suppleirs;
using Havas.Service.DTOs.SuppleirDTOs;
using Havas.Service.Interfaces;
using Havas.Service.Mappers;
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
        private readonly IMapper _mapper;
        private readonly ISuppleirRepository _suppleirRepository;

        public SuppleirService()
        {
            _suppleirRepository = new SuppleirRepository();

            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }



        public Task<Suppleir> CreateAsync(SuppleirForCreationDto model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Suppleir, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Suppleir>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Suppleir, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Suppleir> GetAsync(Expression<Func<Suppleir, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Suppleir> Update(SuppleirForCreationDto model)
        {
            throw new NotImplementedException();
        }
    }
}
