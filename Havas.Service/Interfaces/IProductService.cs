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
        Task<ProductForViewModel> CreateAsync(ProductForCreationDto model);
        Task<bool> DeleteAsync(Expression<Func<Product, bool>> expression);
        Task<ProductForViewModel> UpdateAsync(Expression<Func<Product, bool>> expression, ProductForCreationDto model);
        Task<ProductForViewModel> GetAsync(Expression<Func<Product, bool>> expression);
        Task<IEnumerable<ProductForViewModel>> GetAllAsync(Tuple<int, int> pagination, Expression<Func<Product, bool>>? expression = null);
    }
}
