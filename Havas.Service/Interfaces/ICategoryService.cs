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
        Task<CategoryForViewModel> CreateAsync(CategoryForCreationDto model);
        Task<bool> DeleteAsync(Expression<Func<Category, bool>> expression);
        Task<CategoryForViewModel> Update(Guid id, CategoryForCreationDto model);
        Task<CategoryForViewModel> GetAsync(Expression<Func<Category, bool>> expression);
        Task<IEnumerable<CategoryForViewModel>> GetAllAsync(Tuple<int, int>? pagination = null, Expression<Func<Category, bool>>? expression = null);
    }
}
