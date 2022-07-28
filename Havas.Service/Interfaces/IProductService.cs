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
        Task<Product> CreateAsync(ProductCreation model);
        Task<Product> UpdateAsync(Guid Id, ProductCreation model);
        Task<Product> GetAsync(Expression<Func<Product, bool>> expression);
        Task<bool> DeleteAsync(Expression<Func<Product, bool>> expression);
        Task<IEnumerable<Product>> GetAllAsync(int pageIndex, int pageSize, Expression<Func<Product, bool>> expression = null);
        Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>> expression = null);
    }
}
