using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    [Table("ACCAdvancePayment", Schema = "dbo")]
    public class ACCAdvancePayment
    {

        [Key]     
        public int Id { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string EmployeeName { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string PaymentReason { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public decimal Ammount { get; set; }
        [MaxLength(20)]
        [StringLength(20, ErrorMessage = "عدد الحروم المسموح بها 20 حرف فقط")]
        public string Currency { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public decimal Remaining { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public decimal ExchangeRate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public decimal TotalOtherCurrency { get; set; }
        public string ApprovedBy { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddingDate { get; set; }
        public int ActiveOrNot { get; set; }
    }
}
