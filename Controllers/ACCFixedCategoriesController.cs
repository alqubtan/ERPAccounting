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
    public class FixedCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FixedCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ACCFixedCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ACCFixedCategory.ToListAsync());
        }

        // GET: ACCFixedCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCFixedCategory = await _context.ACCFixedCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aCCFixedCategory == null)
            {
                return NotFound();
            }

            return View(aCCFixedCategory);
        }

        // GET: ACCFixedCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ACCFixedCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryName,Description")] ACCFixedCategory aCCFixedCategory)
        {
            if (ModelState.IsValid)
            {
                var isExist = _context.ACCFixedCategory.Any(o => o.CategoryName == aCCFixedCategory.CategoryName);
                if (isExist)
                {
                    ViewBag.ExistErr = "Category is already exist.";
                    return View();
                }

                _context.Add(aCCFixedCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aCCFixedCategory);
        }

        // GET: ACCFixedCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCFixedCategory = await _context.ACCFixedCategory.FindAsync(id);
            if (aCCFixedCategory == null)
            {
                return NotFound();
            }
            return View(aCCFixedCategory);
        }

        // POST: ACCFixedCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryName,Description")] ACCFixedCategory aCCFixedCategory)
        {
            if (id != aCCFixedCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aCCFixedCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ACCFixedCategoryExists(aCCFixedCategory.Id))
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
            return View(aCCFixedCategory);
        }

        // GET: ACCFixedCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCFixedCategory = await _context.ACCFixedCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aCCFixedCategory == null)
            {
                return NotFound();
            }

            return View(aCCFixedCategory);
        }

        // POST: ACCFixedCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aCCFixedCategory = await _context.ACCFixedCategory.FindAsync(id);
            _context.ACCFixedCategory.Remove(aCCFixedCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ACCFixedCategoryExists(int id)
        {
            return _context.ACCFixedCategory.Any(e => e.Id == id);
        }
    }
}
