using Havas.Data.IRepositories;
using Havas.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
    }
}
