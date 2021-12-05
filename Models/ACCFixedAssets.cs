using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class ACCFixedAssets
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        [Display(Name ="Asset")]
        public string AssetName { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        [Display(Name = "Category")]

        public string Category { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        [Display(Name = "Discription")]

        public string Description { get; set; }
        
        [Display(Name = "Estimated Value")]

        public decimal EstimatedValue { get; set; }
        [Display(Name = "Quantity")]

        public int Quantity { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        [Display(Name = "Brand")]

        public string BrandName { get; set; }
        public int ActiveOrNot { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddingDate { get; set; }


    }
}
