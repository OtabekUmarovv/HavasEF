using AutoMapper;
using Havas.Data.IRepositories;
using Havas.Data.Repositories;
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
        private IMapper _mapper;
        protected readonly ICategoryRepository _categoryRepository;

        public CategoryService()
        {
            _mapper = new MapperConfiguration(cfr =>
            {
                cfr.AddProfile<MappingProfile>();
            }).CreateMapper();

            _categoryRepository = new CategoryRepository();
        }

        public async Task<Category> CreateAsync(CategoryCreation model)
        {
            var existCategory = await _categoryRepository.GetAsync(p => p.Name == model.Name);

            if (existCategory is not null)
                throw new Exception("Category already exist!");

            var mappedCategory = _mapper.Map<Category>(model);

            mappedCategory.Create();

            var result = await _categoryRepository.CreateAsync(mappedCategory);

            await _categoryRepository.SaveAsync();

            return result;

        }

        public async Task<bool> DeleteAsync(Expression<Func<Category, bool>> expression)
        {
            var existCategory = await _categoryRepository.GetAsync(expression);

            if (existCategory is null || existCategory.State == ItemState.Deleted)
                throw new Exception("Category not found");

            existCategory.Delete();

            await _categoryRepository.SaveAsync();

            return true;
        }


        public Task<IEnumerable<Category>> GetAllAsync(int pageIndex, int pageSize, Expression<Func<Category, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAsync(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Guid Id, CategoryCreation model)
        {
            throw new NotImplementedException();
        }
    }
}
