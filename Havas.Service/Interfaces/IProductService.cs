using Havas.Domain.Commons;
using Havas.Domain.Entities.Products;
using Havas.Service.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.Interfaces
{
    public interface IProductService
    {
        Task<BaseResponse<Product>> CreateAsync(ProductCreation model);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Product, bool>> expression);
        Task<BaseResponse<Product>> Update(ProductCreation model);
        Task<BaseResponse<Product>> GetAsync(Expression<Func<Product, bool>> expression);
        Task<BaseResponse<IEnumerable<Product>>> GetAllAsync(Expression<Func<Product, bool>>? expression = null);
        Task<BaseResponse<IEnumerable<Product>>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Product, bool>>? expression = null);
    }
}
