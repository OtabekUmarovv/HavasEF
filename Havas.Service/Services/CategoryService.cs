using AutoMapper;
using Havas.Data.IRepositories;
using Havas.Data.Repositories;
using Havas.Domain.Commons;
using Havas.Domain.Entities.Products;
using Havas.Domain.Enums;
using Havas.Service.DTOs.ProductDTOs;
using Havas.Service.Extensions;
using Havas.Service.Interfaces;
using Havas.Service.Mappers;
using Microsoft.EntityFrameworkCore;
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

        public async Task<CategoryForViewModel> CreateAsync(CategoryForCreationDto model)
        {
            var exist = await _categoryRepository.GetAsync(p => p.Name == model.Name);

            if(exist is not null && exist.State != ItemState.Deleted) 
            {
                throw new Exception("Category already exist!");
            }

            else if(exist is not null && exist.State == ItemState.Created)
            {
                exist = _mapper.Map(model, exist);
                exist.Update();

                exist =_categoryRepository.Update(exist);
            }

            else
            {
                var entity = _mapper.Map<Category>(model);
                entity.Create();

                exist = await _categoryRepository.CreateAsync(entity);

            }

            await _categoryRepository.SaveChangesAsync();

            return _mapper.Map<CategoryForViewModel>(exist);
        }


        public async Task<bool> DeleteAsync(Expression<Func<Category, bool>> expression)
        {
            var category = await _categoryRepository.GetAsync(expression);

            if (category is null || category.State == ItemState.Deleted)
                throw new Exception("Category not found");

            var products = (await _categoryRepository.GetAll(expression)
                    .Include("Products").FirstOrDefaultAsync(expression)).Products.ToList();

            for (int i = 0; i < products.Count(); i++)
                products[i].State = ItemState.Deleted;

            await _categoryRepository.SaveChangesAsync();

            return true;
        }

        public Task<IEnumerable<CategoryForViewModel>> GetAllAsync
            (Tuple<int, int>? pagination = null, Expression<Func<Category, bool>>? expression = null)
               => Task.FromResult(_mapper.Map<IEnumerable<CategoryForViewModel>>(_categoryRepository
                   .GetAll(expression).Where(p => p.State != ItemState.Deleted).Include("Products")
                        .GetWithPagination(pagination)));

            
        

        public async Task<CategoryForViewModel> GetAsync(Expression<Func<Category, bool>> expression)
        {
            var category = await (_categoryRepository.GetAll(expression)
                .Include("Products")
                    .FirstOrDefaultAsync(expression));

            if (category is null || category.State == ItemState.Deleted)
                throw new Exception("Category not found!");

            return _mapper.Map<CategoryForViewModel>(category);
        }

        public async Task<CategoryForViewModel> Update(Guid id, CategoryForCreationDto model)
        {
            var categoryToUpdate = await _categoryRepository.GetAsync(p => p.Id == id);

            if (category is null || category.State == ItemState.Deleted)
                throw new Exception("Category not found");

            category  = _mapper.Map(model, category);
            
            category.Update();
            




        }
    }
}
