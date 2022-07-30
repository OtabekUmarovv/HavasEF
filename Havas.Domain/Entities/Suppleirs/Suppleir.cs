using Havas.Domain.Commons;
using Havas.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Domain.Entities.Suppleirs
{
    public class Suppleir : Auditable
    {
        [MinLength(2), MaxLength(64)]
        public string? CompanyName { get; set; }

        [MinLength(2), MaxLength(64)]
        public string? Email { get; set; }

        [MaxLength(16)]
        public string? Phone { get; set; }
        public string? Adress { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
