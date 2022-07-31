using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.DTOs.ProductDTOs
{
    public class ProductForViewModel
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public int? Discount { get; set; }
        public string? CategoryName { get; set; }
        public string? SuppleirName { get; set; }

    }
}
