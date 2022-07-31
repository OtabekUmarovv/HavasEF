using Havas.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.DTOs.ProductDTOs
{
    public class CategoryForViewModel
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
