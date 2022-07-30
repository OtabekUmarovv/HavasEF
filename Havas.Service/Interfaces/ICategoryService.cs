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
    public interface ICategoryService
    {
        Task<BaseResponse<Category>> CreateAsync(CategoryCreation model);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Category, bool>> expression);
        Task<BaseResponse<Category>> Update(CategoryCreation model);
        Task<BaseResponse<Category>> GetAsync(Expression<Func<Category, bool>> expression);
        Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(Expression<Func<Category, bool>>? expression = null);
        Task<BaseResponse<IEnumerable<Category>>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Category, bool>>? expression = null);
    }
}
