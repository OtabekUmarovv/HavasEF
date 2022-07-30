using Havas.Domain.Commons;
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
        public Task<BaseResponse<Product>> CreateAsync(ProductCreation model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Product>>> GetAllAsync(Expression<Func<Product, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Product>>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Product, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Product>> GetAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Product>> Update(ProductCreation model)
        {
            throw new NotImplementedException();
        }
    }
}
