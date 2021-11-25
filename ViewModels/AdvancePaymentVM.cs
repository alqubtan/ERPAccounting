using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.ViewModels
{
    public class AdvancePaymentVM
    {
        public List<SelectListItem> Itemss { get; set; }
        public Models.ACCAdvancePayment advancePayment { get; set; }
    }
}
