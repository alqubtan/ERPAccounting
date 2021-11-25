using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SamaERP.Data;
using SamaERP.Models;


namespace SamaERP.Controllers
{

    public class PurchasesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PurchasesController(ApplicationDbContext context)
        {

            _context = context;
        }

        // GET: Purchases
        public async Task<IActionResult> Index()
        {


            return View(await _context.ACCAdvancePayment.Where(o => o.Remaining > 0).ToListAsync());
        }

        // GET: Purchases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewModels.PurchasesVM vm = new ViewModels.PurchasesVM();
            List<ACCPurchases> pr = new List<ACCPurchases>();
            vm.advancePayment = await _context.ACCAdvancePayment.FirstOrDefaultAsync(m => m.Id == id && m.ActiveOrNot == 1);
            vm.purchases = pr;
            var myList = _context.ACCsupliers.Where(o => o.ActiveOrNot == 1).Select(cat => new SelectListItem { Text = cat.SuplierName, Value = cat.SuplierName }).ToList();

            ViewBag.SupliersList = myList;
            return View(vm);
        }

        // GET: Purchases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Purchases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SuplierName,EmployeeName,ItemName,Qty,Price,TotalPrice,ExchangeRate,TotalOtherCurrency,Currency,ApprovedBy,AddedBy,AddingDate,ActiveOrNot")] ACCPurchases purchases)
        {
            if (ModelState.IsValid)
            {
                //   purchases.Id = Guid.NewGuid();
                _context.Add(purchases);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(purchases);
        }

        // GET: Purchases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchases = await _context.ACCPurchases.FindAsync(id);
            if (purchases == null)
            {
                return NotFound();
            }
            return View(purchases);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SuplierName,EmployeeName,ItemName,Qty,Price,TotalPrice,ExchangeRate,TotalOtherCurrency,Currency,ApprovedBy,AddedBy,AddingDate,ActiveOrNot")] ACCPurchases purchases)
        {
            if (id != purchases.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchases);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchasesExists(purchases.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(purchases);
        }

        // GET: Purchases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchases = await _context.ACCPurchases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchases == null)
            {
                return NotFound();
            }

            return View(purchases);
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchases = await _context.ACCPurchases.FindAsync(id);
            _context.ACCPurchases.Remove(purchases);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchasesExists(int id)
        {
            return _context.ACCPurchases.Any(e => e.Id == id);
        }




        //My APIs

        [HttpPost]
        public async Task<IActionResult> PartialDetails(string SuplierName, string EmployeeName, string ItemName, string PurchaseNo, int PurchaseID
           , string PruchaseDate, double Qty, decimal Price, decimal TotalPrice, decimal ExchangeRate, decimal TotalOtherCurrency, string Currency, string OtherCurrency, int EmployeeID)
        {
            bool _Authinticated = HttpContext.User.Identity.IsAuthenticated;
            if (true)
            {
                string user = HttpContext.User.Identity.Name;
                try
                {
                    ACCPurchases ph = new ACCPurchases();
                    //    var _emp= _context.employeeDetails.Where(o => o.EmployeeName == EmployeeName).FirstOrDefault();
                    var _adv = _context.ACCAdvancePayment.Where(o => o.Id == EmployeeID).FirstOrDefault();
                    ph.ActiveOrNot = 1;
                    ph.AddedBy = user;
                    ph.AddingDate = DateTime.UtcNow.AddHours(3);
                    ph.ApprovedBy = "Later";
                    ph.Qty = Qty;
                    ph.ExchangeRate = ExchangeRate;
                    decimal _currentremaining;
                    ph.OtherCurrency = Currency;
                    ph.Currency = OtherCurrency;
                    if (_adv.Currency == Currency)
                    {

                        ph.OtherCurrency = OtherCurrency;
                        ph.Currency = Currency;
                        ph.Price = Price;
                        ph.TotalOtherCurrency = TotalOtherCurrency;
                        ph.TotalPrice = TotalPrice;
                        _currentremaining = _adv.Remaining;
                        _adv.Remaining = _currentremaining - TotalPrice;


                    }
                    else
                    {

                        if (Currency == "USD")
                        {
                            if (_adv.Currency == "USD")
                            {
                                ph.Price = Price * ExchangeRate;
                                ph.TotalPrice = TotalPrice;
                                ph.TotalOtherCurrency = Math.Truncate((TotalPrice * ExchangeRate) * 100) / 100;
                                _currentremaining = _adv.Remaining;
                                _adv.Remaining = _currentremaining - ph.TotalPrice;
                            }
                            else
                            {
                                ph.Price = Price * ExchangeRate;
                                ph.TotalPrice = TotalPrice * ExchangeRate;
                                ph.TotalOtherCurrency = Math.Truncate((TotalPrice) * 100) / 100;
                                _currentremaining = _adv.Remaining;

                                _adv.Remaining = _currentremaining - ph.TotalPrice;
                            }
                        }
                        else
                        {
                            ph.Price = Price / ExchangeRate;
                            ph.TotalPrice = TotalPrice / ExchangeRate;
                            ph.TotalOtherCurrency = TotalOtherCurrency * ExchangeRate;
                            _currentremaining = _adv.Remaining;
                            _adv.Remaining = _currentremaining - ph.TotalPrice;

                        }

                    }
                    ph.EmployeeID = PurchaseID;
                    ph.EmployeeName = EmployeeName;
                    ph.ItemName = ItemName;
                    ph.PruchaseDate = Convert.ToDateTime(PruchaseDate).Date;
                    ph.PurchaseNo = PurchaseNo;
                    ph.SuplierName = SuplierName;
                    ph.EmployeeID = EmployeeID;
                    _context.ACCAdvancePayment.Update(_adv);
                    _context.ACCPurchases.Add(ph);

                    await _context.SaveChangesAsync();

                    //    _toastNotification.AddSuccessToastMessage("Purchase Order Added Successfully");
                    return Json(ph);

                }
                catch (Exception ex)
                {

                    string err = ex.Message;
                    return null;
                }

            }
            return null;

        }




        [HttpPost]
        public async Task<IActionResult> GetPartialDetails(int EmployeeID)
        {
            bool _Authinticated = HttpContext.User.Identity.IsAuthenticated;
            if (_Authinticated)
            {
                string user = HttpContext.User.Identity.Name;
                try
                {
                    List<ACCPurchases> rtval = new List<ACCPurchases>();
                    var ph = await _context.ACCPurchases.Where(o => o.ActiveOrNot == 1 && o.EmployeeID == EmployeeID).ToListAsync();
                    foreach (var at in ph)
                    {
                        if (at.Currency == "USD")
                        {
                            at.Price = Math.Truncate(at.Price * 100) / 100;
                            at.TotalPrice = Math.Truncate(at.TotalPrice * 100) / 100;
                            at.TotalOtherCurrency = Math.Truncate(at.TotalOtherCurrency * 1000) / 1000;
                        }
                        else
                        {
                            at.Price = Math.Truncate(at.Price * 1000) / 1000;
                            at.TotalPrice = Math.Truncate(at.TotalPrice * 1000) / 1000;
                            at.TotalOtherCurrency = Math.Truncate(at.TotalOtherCurrency * 100) / 100;
                        }
                        rtval.Add(at);

                    }
                    return Json(rtval);

                }
                catch (Exception ex)
                {

                    string err = ex.Message;
                    return null;
                }

            }
            return null;

        }

        [HttpPost]
        public async Task<IActionResult> DeleteRow(int id)
        {
            bool _Authinticated = HttpContext.User.Identity.IsAuthenticated;
            if (true)
            {
                string user = HttpContext.User.Identity.Name;

                var _check = _context.ACCPurchases.Any(o => o.Id == id);
                if (_check)
                {
                    try
                    {
                        var _totalRows = _context.ACCPurchases.Where(o => (o.Id == id)).FirstOrDefault();
                        var _advancePayments = _context.ACCAdvancePayment.Where(o => o.Id.Equals(_totalRows.EmployeeID)).FirstOrDefault();
                        _advancePayments.Remaining = _advancePayments.Remaining + _totalRows.TotalPrice;
                        _context.ACCAdvancePayment.Update(_advancePayments);
                        _context.ACCPurchases.Remove(_totalRows);
                        await _context.SaveChangesAsync();


                        return Json(_totalRows);

                    }
                    catch
                    {

                        return null;
                    }

                }
                return null;
            }
            else
            {

            }
            return null;
        }

    }
}
