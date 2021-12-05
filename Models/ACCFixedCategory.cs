using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class ACCFixedCategory
    {
        [Key]

        [Required]
        public int Id { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        [Display(Name = "Category Name")]
        [Required]
        public string CategoryName { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
