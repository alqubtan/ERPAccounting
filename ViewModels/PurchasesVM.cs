using SamaERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.ViewModels
{
    public class PurchasesVM
    {
        public Models.ACCAdvancePayment advancePayment { get; set; }
        public List<Models.ACCPurchases> purchases { get; set; }
    }
}
