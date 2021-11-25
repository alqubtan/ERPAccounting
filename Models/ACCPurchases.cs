using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace SamaERP.Models
{
    [Table("ACCPurchases", Schema = "dbo")]
    public class ACCPurchases
    {
        [Key]     
        public int Id { get; set; }
        public int AdvancPaymentID { get; set; } = 0;
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string SuplierName { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string ItemName { get; set; }
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "عدد الحروم المسموح بها 50 حرف فقط")]
        public string PurchaseNo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PruchaseDate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public double Qty { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public decimal TotalPrice { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DisplayFormat(DataFormatString = "{0:00}", ApplyFormatInEditMode = true)]
        public decimal ExchangeRate { get; set; }
        [MaxLength(20)]
        [StringLength(20, ErrorMessage = "عدد الحروم المسموح بها 20 حرف فقط")]
        public decimal TotalOtherCurrency { get; set; }
        [MaxLength(20)]
        [StringLength(20, ErrorMessage = "عدد الحروم المسموح بها 20 حرف فقط")]
        public string Currency { get; set; }
        [MaxLength(20)]
        [StringLength(20, ErrorMessage = "عدد الحروم المسموح بها 20 حرف فقط")]
        public string OtherCurrency { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string ApprovedBy { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddingDate { get; set; }
        public int ActiveOrNot { get; set; }
    }
}
