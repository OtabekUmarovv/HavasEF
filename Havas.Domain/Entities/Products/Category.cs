using Havas.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Domain.Entities.Products
{
    public class Category : Auditable
    {
        [MaxLength(64)]
        public string Name { get; set; }

        public string Description { get; set; }
        public ICollection<Product>? Products { get; set; }


    }
}
