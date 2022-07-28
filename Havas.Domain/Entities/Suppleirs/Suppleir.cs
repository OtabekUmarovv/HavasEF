using Havas.Domain.Commons;
using Havas.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Domain.Entities.Suppleirs
{
    public class Suppleir : Auditable
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
