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

    public class SupliersController : Controller
    {

        private readonly ApplicationDbContext _context;


        public SupliersController(ApplicationDbContext context)
        {

            _context = context;
        }

        // GET: Supliers
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            try
            {
                ViewData["CurrentSort"] = sortOrder;
                ViewData["SupplierNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "SupplierName_desc" : "";
                ViewData["PhoneNumberSortParm"] = sortOrder == "PhoneNumber" ? "PhoneNumber_desc" : "PhoneNumber";
                ViewData["SupplierSpecializationSortParm"] = sortOrder == "SupplierSpecialization" ? "SupplierSpecialization_desc" : "SupplierSpecialization";
                ViewData["AddingDateSortParm"] = sortOrder == "AddingDate" ? "AddingDate_desc" : "AddingDate";


                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }
                ViewData["CurrentFilter"] = searchString;
                var items = _context.ACCsupliers.Where(o => o.ActiveOrNot == 1);
                if (!String.IsNullOrEmpty(searchString))
                {
                    items = items.Where(s => s.SuplierName.Contains(searchString) || s.PhoneNo.Contains(searchString) || s.SuplierType.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "SupplierName_desc":
                        items = items.OrderByDescending(s => s.SuplierName);
                        break;
                    case "PhoneNumber":
                        items = items.OrderBy(s => s.PhoneNo);
                        break;
                    case "PhoneNumber_desc":
                        items = items.OrderByDescending(s => s.PhoneNo);
                        break;
                    case "SupplierSpecialization":
                        items = items.OrderBy(s => s.SuplierType);
                        break;
                    case "SupplierSpecialization_desc":
                        items = items.OrderByDescending(s => s.SuplierType);
                        break;
                    case "AddingDate":
                        items = items.OrderBy(s => s.AddingDate);
                        break;
                    case "AddingDate_desc":
                        items = items.OrderByDescending(s => s.AddingDate);
                        break;

                    default:
                        items = items.OrderByDescending(s => s.SuplierName);
                        break;
                }

                int pageSize = 10;

                return View(await PaginatedList<Models.ACCSupliers>.CreateAsync(items.AsNoTracking(), pageNumber ?? 1, pageSize));

            }
            catch (Exception ex)
            {

                return null;
            }

        }

        // GET: Supliers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supliers = await _context.ACCsupliers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supliers == null)
            {
                return NotFound();
            }

            return View(supliers);
        }

        // GET: Supliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Supliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SuplierName,PhoneNo,Email,Addr,SuplierType,AddedBy,AddingDate,ActiveOrNot")] ACCSupliers supliers)
        {
            if (ModelState.IsValid)
            {
                //  supliers.Id = Guid.NewGuid();
                _context.Add(supliers);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Supliers", new { Area = "Accounting" });
            }
            return View(supliers);
        }

        // GET: Supliers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supliers = await _context.ACCsupliers.FindAsync(id);
            if (supliers == null)
            {
                return NotFound();
            }
            return View(supliers);
        }

        // POST: Supliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SuplierName,PhoneNo,Email,Addr,SuplierType,AddedBy,AddingDate,ActiveOrNot")] ACCSupliers supliers)
        {
            if (id != supliers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supliers);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupliersExists(supliers.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Supliers", new { Area = "Accounting" });
            }
            return View(supliers);
        }

        // GET: Supliers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supliers = await _context.ACCsupliers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supliers == null)
            {
                return NotFound();
            }

            return View(supliers);
        }

        // POST: Supliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supliers = await _context.ACCsupliers.FindAsync(id);
            _context.ACCsupliers.Remove(supliers);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Supliers", new { Area = "Accounting" });
        }

        private bool SupliersExists(int id)
        {
            return _context.ACCsupliers.Any(e => e.Id == id);
        }
    }
}
