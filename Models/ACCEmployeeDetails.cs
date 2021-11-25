using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    [Table("ACCEmployeeDetails", Schema = "dbo")]
    public class ACCEmployeeDetails
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string EmployeeName { get; set; }
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "عدد الحروم المسموح بها 50 حرف فقط")]
        public string PhoneNo { get; set; }
        [MaxLength(250)]
        [DataType(DataType.EmailAddress)]
        [StringLength(250, ErrorMessage = "عدد الحروم المسموح بها 250 حرف فقط")]
        public string Email { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string Addr { get; set; }
        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string Department { get; set; }

        [MaxLength(500)]
        [StringLength(500, ErrorMessage = "عدد الحروم المسموح بها 500 حرف فقط")]
        public string JobTitle { get; set; }

        public string AddedBy { get; set; }
        public DateTime AddingDate { get; set; }
        public int ActiveOrNot { get; set; }
    }
}
