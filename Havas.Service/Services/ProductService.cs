using Havas.Domain.Entities.Products;
using Havas.Service.DTOs.ProductDTOs;
using Havas.Service.Interfaces;
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
        public Task<Product> CreateAsync(ProductCreation model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync(int pageIndex, int pageSize, Expression<Func<Product, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Guid Id, ProductCreation model)
        {
            throw new NotImplementedException();
        }
    }
}
