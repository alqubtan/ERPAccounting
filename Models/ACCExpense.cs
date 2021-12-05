using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Expense Type")]
        public string ExpenseType { get; set; }

        [Required]
        [Display(Name = "Data")]
        public DateTime ExpenseData { get; set; }
        [Required]
        [Display(Name = "Payment Account")]
        public string PaymentAccount { get; set; }
        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }
        [Required]
        [Display(Name = "Currency")]
        public string Currency { get; set; }
    }
}
