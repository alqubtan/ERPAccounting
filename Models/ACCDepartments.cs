using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    [Table("ACCDepartments", Schema = "dbo")]
    public class ACCDepartments
    {
        [Key]
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string Disciption { get; set; }
        public int ActiveOrNot { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddingDate { get; set; }
    }
}
