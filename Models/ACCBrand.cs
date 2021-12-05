using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class Brand
    {
        [Key]

        public int Id { get; set; }

        [Required]
        [Display(Name ="Brand Name")]
        public string BrandName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
