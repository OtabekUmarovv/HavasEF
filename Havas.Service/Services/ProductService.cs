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
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();

            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }

        public async Task<ProductForViewModel> CreateAsync(ProductForCreationDto model)
        {
            var exist = await _productRepository.GetAsync(p => p.Name == model.Name);
        
            if(exist is not null)
            {
                throw new Exception("Category already exist");
            }


        }

        public Task<bool> DeleteAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductForViewModel>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Product, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<ProductForViewModel> GetAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }


        public Task<ProductForViewModel> UpdateAsync(Guid id, ProductForCreationDto model)
        {
            throw new NotImplementedException();
        }
    }
}
