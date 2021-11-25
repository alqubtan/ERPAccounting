
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SamaERP.Data;
using SamaERP.Models;


using Microsoft.AspNetCore.Authorization;

namespace SamaERP.Controllers
{

    public class EmployeeDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeDetailsController(ApplicationDbContext context)
        {

            _context = context;
        }

        // GET: EmployeeDetails
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            try
            {
                ViewData["CurrentSort"] = sortOrder;
                ViewData["Col1SortParm"] = String.IsNullOrEmpty(sortOrder) ? "Col1_desc" : "";
                ViewData["Col2SortParm"] = sortOrder == "Col2" ? "Col2_desc" : "Col2";
                ViewData["Col3SortParm"] = sortOrder == "Col3" ? "Col3_desc" : "Col3";


                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }
                ViewData["CurrentFilter"] = searchString;
                var items = _context.ACCEmployeeDetails.Where(o => o.ActiveOrNot == 1);
                if (!String.IsNullOrEmpty(searchString))
                {
                    items = items.Where(s => s.EmployeeName.Contains(searchString) || s.Department.Contains(searchString) || s.JobTitle.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "Col1_desc":
                        items = items.OrderByDescending(s => s.EmployeeName);
                        break;
                    case "Col2":
                        items = items.OrderBy(s => s.Department);
                        break;
                    case "Col2_desc":
                        items = items.OrderByDescending(s => s.Department);
                        break;
                    case "Col3":
                        items = items.OrderBy(s => s.JobTitle);
                        break;
                    case "Col3_desc":
                        items = items.OrderByDescending(s => s.JobTitle);
                        break;


                    default:
                        items = items.OrderByDescending(s => s.EmployeeName);
                        break;
                }

                int pageSize = 10;

                return View(await PaginatedList<Models.ACCEmployeeDetails>.CreateAsync(items.AsNoTracking(), pageNumber ?? 1, pageSize));

            }
            catch (Exception ex)
            {

                throw;
            }



            //   return View(await _context.ACCemployeeDetails.ToListAsync());
        }

        // GET: EmployeeDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeDetails = await _context.ACCEmployeeDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeDetails == null)
            {
                return NotFound();
            }

            return View(employeeDetails);
        }

        // GET: EmployeeDetails/Create
        public IActionResult Create()
        {


            ViewBag.Departments = _context.Departments.Where(o => o.ActiveOrNot == 1).OrderBy(o => o.DepartmentName).Select(cat => new SelectListItem { Value = cat.DepartmentName, Text = cat.DepartmentName }).ToList();
            return View();
        }

        // POST: EmployeeDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeName,PhoneNo,Email,Addr,Department,AddedBy,AddingDate,ActiveOrNot,JobTitle")] ACCEmployeeDetails employeeDetails)
        {
            if (ModelState.IsValid)
            {
                //  employeeDetails.Id = Guid.NewGuid();
                _context.Add(employeeDetails);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "EmployeeDetails", new { area = "Accounting" });
            }
            return View(employeeDetails);
        }

        // GET: EmployeeDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Departments = _context.Departments.Where(o => o.ActiveOrNot == 1).OrderBy(o => o.DepartmentName).Select(cat => new SelectListItem { Value = cat.DepartmentName, Text = cat.DepartmentName }).ToList();

            var employeeDetails = await _context.ACCEmployeeDetails.FindAsync(id);
            if (employeeDetails == null)
            {
                return NotFound();
            }
            return View(employeeDetails);
        }

        // POST: EmployeeDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmployeeName,PhoneNo,Email,Addr,Department,AddedBy,AddingDate,ActiveOrNot,JobTitle")] ACCEmployeeDetails employeeDetails)
        {
            if (id != employeeDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeDetails);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeDetailsExists(employeeDetails.Id))
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
            return View(employeeDetails);
        }

        // GET: EmployeeDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeDetails = await _context.ACCEmployeeDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeDetails == null)
            {
                return NotFound();
            }

            return View(employeeDetails);
        }

        // POST: EmployeeDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeDetails = await _context.ACCEmployeeDetails.FindAsync(id);
            _context.ACCEmployeeDetails.Remove(employeeDetails);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeDetailsExists(int id)
        {
            return _context.ACCEmployeeDetails.Any(e => e.Id == id);
        }
    }
}
