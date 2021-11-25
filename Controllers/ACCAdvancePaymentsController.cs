using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SamaERP.Data;
using Microsoft.AspNetCore.Authorization;

using SamaERP.Models;

namespace SamaERP.Controllers
{

    public class AdvancePaymentsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AdvancePaymentsController(ApplicationDbContext context)
        {

            _context = context;
        }

        // GET: AdvancePayments
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            try
            {
                ViewData["CurrentSort"] = sortOrder;
                ViewData["Col1SortParm"] = String.IsNullOrEmpty(sortOrder) ? "Col1_desc" : "";
                ViewData["Col2SortParm"] = sortOrder == "Col2" ? "Col2_desc" : "Col2";
                ViewData["Col3SortParm"] = sortOrder == "Col3" ? "Col3_desc" : "Col3";
                ViewData["Col4SortParm"] = sortOrder == "Col4" ? "Col4_desc" : "Col4";
                ViewData["Col5SortParm"] = sortOrder == "Col5" ? "Col5_desc" : "Col5";
                ViewData["Col6SortParm"] = sortOrder == "Col6" ? "Col6_desc" : "Col6";
                ViewData["Col7SortParm"] = sortOrder == "Col7" ? "Col7_desc" : "Col7";




                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }
                ViewData["CurrentFilter"] = searchString;
                var items = _context.ACCAdvancePayment.Where(o => o.ActiveOrNot == 1);
                if (!String.IsNullOrEmpty(searchString))
                {
                    items = items.Where(s => s.EmployeeName.Contains(searchString) || s.PaymentReason.Contains(searchString) || s.ApprovedBy.Contains(searchString) || s.Currency.Contains(searchString))
                    ;
                }
                switch (sortOrder)
                {
                    case "Col1_desc":
                        items = items.OrderByDescending(s => s.EmployeeName);
                        break;
                    case "Col2":
                        items = items.OrderBy(s => s.PaymentReason);
                        break;
                    case "Col2_desc":
                        items = items.OrderByDescending(s => s.PaymentReason);
                        break;

                    case "Col3":
                        items = items.OrderBy(s => s.Ammount);
                        break;
                    case "Col3_desc":
                        items = items.OrderByDescending(s => s.Ammount);
                        break;
                    case "Col4":
                        items = items.OrderBy(s => s.Remaining);
                        break;
                    case "Col4_desc":
                        items = items.OrderByDescending(s => s.Remaining);
                        break;
                    case "Col5":
                        items = items.OrderBy(s => s.Currency);
                        break;
                    case "Col5_desc":
                        items = items.OrderByDescending(s => s.Currency);
                        break;
                    case "Col6":
                        items = items.OrderBy(s => s.ApprovedBy);
                        break;
                    case "Col6_desc":
                        items = items.OrderByDescending(s => s.ApprovedBy);
                        break;
                    case "Col7":
                        items = items.OrderBy(s => s.AddingDate);
                        break;
                    case "Col7_desc":
                        items = items.OrderByDescending(s => s.AddingDate);
                        break;

                    default:
                        items = items.OrderByDescending(s => s.EmployeeName);
                        break;
                }

                int pageSize = 10;

                return View(await PaginatedList<SamaERP.Models.ACCAdvancePayment>.CreateAsync(items.AsNoTracking(), pageNumber ?? 1, pageSize));

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        // GET: AdvancePayments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advancePayment = await _context.ACCAdvancePayment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advancePayment == null)
            {
                return NotFound();
            }

            return View(advancePayment);
        }

        // GET: AdvancePayments/Create
        public IActionResult Create()
        {


            var myList = _context.ACCEmployeeDetails.Where(o => o.ActiveOrNot == 1).Select(cat => new SelectListItem { Text = cat.EmployeeName, Value = cat.EmployeeName }).ToList();

            ViewBag.Emplyees = myList;


            return View();
        }

        // POST: AdvancePayments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeName,PaymentReason,Ammount,Currency,Remaining,ExchangeRate,TotalOtherCurrency,ApprovedBy,AddedBy,AddingDate,ActiveOrNot")] ACCAdvancePayment advancePayment)
        {
            if (ModelState.IsValid)
            {
                // advancePayment.Id = Guid.NewGuid();
                advancePayment.Remaining = advancePayment.Ammount;
                _context.Add(advancePayment);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(advancePayment);
        }

        // GET: AdvancePayments/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myList = _context.ACCEmployeeDetails.Where(o => o.ActiveOrNot == 1).Select(cat => new SelectListItem { Text = cat.EmployeeName, Value = cat.EmployeeName }).ToList();

            ViewBag.Emplyees = myList;
            var advancePayment = await _context.ACCAdvancePayment.FindAsync(id);
            if (advancePayment == null)
            {
                return NotFound();
            }
            return View(advancePayment);
        }

        // POST: AdvancePayments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmployeeName,PaymentReason,Ammount,Currency,Remaining,ExchangeRate,TotalOtherCurrency,ApprovedBy,AddedBy,AddingDate,ActiveOrNot")] ACCAdvancePayment advancePayment)
        {
            if (id != advancePayment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    advancePayment.Remaining = advancePayment.Ammount;
                    _context.Update(advancePayment);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvancePaymentExists(advancePayment.Id))
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
            return View(advancePayment);
        }

        // GET: AdvancePayments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advancePayment = await _context.ACCAdvancePayment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advancePayment == null)
            {
                return NotFound();
            }

            return View(advancePayment);
        }

        // POST: AdvancePayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advancePayment = await _context.ACCAdvancePayment.FindAsync(id);
            _context.ACCAdvancePayment.Remove(advancePayment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool AdvancePaymentExists(int id)
        {
            return _context.ACCAdvancePayment.Any(e => e.Id == id);
        }
    }
}
