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

    public class DepartmentsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public DepartmentsController(ApplicationDbContext context)
        {

            _context = context;
        }

        // GET: Accounting/Departments
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            try
            {
                ViewData["CurrentSort"] = sortOrder;
                ViewData["Col1SortParm"] = String.IsNullOrEmpty(sortOrder) ? "Col1_desc" : "";
                ViewData["Col2SortParm"] = sortOrder == "Col2" ? "Col2_desc" : "Col2";



                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }
                ViewData["CurrentFilter"] = searchString;
                var items = _context.Departments.Where(o => o.ActiveOrNot == 1);
                if (!String.IsNullOrEmpty(searchString))
                {
                    items = items.Where(s => s.DepartmentName.Contains(searchString) || s.Disciption.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "Col1_desc":
                        items = items.OrderByDescending(s => s.DepartmentName);
                        break;
                    case "Col2":
                        items = items.OrderBy(s => s.Disciption);
                        break;
                    case "Col2_desc":
                        items = items.OrderByDescending(s => s.Disciption);
                        break;

                    default:
                        items = items.OrderByDescending(s => s.DepartmentName);
                        break;
                }

                int pageSize = 10;

                return View(await PaginatedList<SamaERP.Models.ACCDepartments>.CreateAsync(items.AsNoTracking(), pageNumber ?? 1, pageSize));

            }
            catch (Exception ex)
            {

                throw;
            }

            //  return View(await _context.Departments.ToListAsync());
        }

        // GET: Accounting/Departments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departments = await _context.Departments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departments == null)
            {
                return NotFound();
            }

            return View(departments);
        }

        // GET: Accounting/Departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounting/Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DepartmentName,Disciption,ActiveOrNot,AddedBy,AddingDate")] ACCDepartments departments)
        {
            if (ModelState.IsValid)
            {
                departments.Id = Guid.NewGuid();
                _context.Add(departments);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(departments);
        }

        // GET: Accounting/Departments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departments = await _context.Departments.FindAsync(id);
            if (departments == null)
            {
                return NotFound();
            }
            return View(departments);
        }

        // POST: Accounting/Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,DepartmentName,Disciption,ActiveOrNot,AddedBy,AddingDate")] ACCDepartments departments)
        {
            if (id != departments.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentsExists(departments.Id))
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
            return View(departments);
        }

        // GET: Accounting/Departments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departments = await _context.Departments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departments == null)
            {
                return NotFound();
            }

            return View(departments);
        }

        // POST: Accounting/Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var departments = await _context.Departments.FindAsync(id);
            _context.Departments.Remove(departments);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentsExists(Guid id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
