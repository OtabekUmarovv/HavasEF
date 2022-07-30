using AutoMapper;
using Havas.Data.IRepositories;
using Havas.Data.Repositories;
using Havas.Domain.Commons;
using Havas.Domain.Entities.Products;
using Havas.Domain.Enums;
using Havas.Service.DTOs.ProductDTOs;
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
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();

            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }

        public async Task<BaseResponse<Category>> CreateAsync(CategoryCreation model)
        {
            var response = new BaseResponse<Category>()
            {
                Data = await _categoryRepository.CreateAsync(_mapper.Map<Category>(model))
            };

            if(!re)
            return response;
            
      
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(Expression<Func<Category, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Category, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Category>> GetAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Category>> Update(CategoryCreation model)
        {
            throw new NotImplementedException();
        }
    }
}
