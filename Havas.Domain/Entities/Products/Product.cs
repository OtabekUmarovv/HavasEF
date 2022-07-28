using Havas.Domain.Commons;
using Havas.Domain.Entities.Suppleirs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; } = 0;

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid SuppleirId { get; set; }
        public Suppleir Suppleir { get; set; }
    }
}
