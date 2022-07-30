using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.DTOs.SuppleirDTOs
{
    public class SuppleirCreation
    {
        [Required, MaxLength(128), MinLength(2)]
        public string? CompanyName { get; set; }
        
        
        [Required, MaxLength(128), MinLength(2), EmailAddress]
        public string? Email { get; set; }


        [Required, MinLength(2), MaxLength(16), Phone]
        public string? Phone { get; set; }
        
        [MinLength(2)]
        public string? Adress { get; set; }
    }
}
