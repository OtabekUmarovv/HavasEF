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
        Task<Category> CreateAsync(CategoryCreation model);
        Task<Category> UpdateAsync(Guid Id, CategoryCreation model);
        Task<Category> GetAsync(Expression<Func<Category, bool>> expression);
        Task<bool> DeleteAsync(Expression<Func<Category, bool>> expression);
        Task<IEnumerable<Category>> GetAllAsync(int pageIndex, int pageSize, Expression<Func<Category, bool>> expression = null);
        Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>> expression = null);
    }
}
