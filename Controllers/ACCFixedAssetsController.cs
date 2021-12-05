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
    public class FixedAssetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FixedAssetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ACCFixedAssets
        public async Task<IActionResult> Index()
        {
            return View(await _context.ACCFixedAssets.ToListAsync());
        }

        // GET: ACCFixedAssets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCFixedAssets = await _context.ACCFixedAssets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aCCFixedAssets == null)
            {
                return NotFound();
            }

            return View(aCCFixedAssets);
        }

        // GET: ACCFixedAssets/Create
        public IActionResult Create()
        {
            var categories = _context.ACCFixedCategory.ToList();
            var brands = _context.Brand.ToList();
            ViewBag.categories = new SelectList(categories, "CategoryName", "CategoryName");
            ViewBag.brands = new SelectList(brands, "BrandName", "BrandName");
            return View();
        }

        // POST: ACCFixedAssets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AssetName,Category,Description,EstimatedValue,Quantity,BrandName")] ACCFixedAssets aCCFixedAssets)
        {
            var categories = _context.ACCFixedCategory.ToList();
            var brands = _context.Brand.ToList();
            ViewBag.brands = new SelectList(brands, "BrandName", "BrandName");
            ViewBag.categories = new SelectList(categories, "CategoryName", "CategoryName");
            
            if (ModelState.IsValid)
            {
                _context.Add(aCCFixedAssets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aCCFixedAssets);
        }

        // GET: ACCFixedAssets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCFixedAssets = await _context.ACCFixedAssets.FindAsync(id);
            if (aCCFixedAssets == null)
            {
                return NotFound();
            }
            return View(aCCFixedAssets);
        }

        // POST: ACCFixedAssets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AssetName,Category,Description,EstimatedValue,Quantity,BrandName")] ACCFixedAssets aCCFixedAssets)
        {
            if (id != aCCFixedAssets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aCCFixedAssets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ACCFixedAssetsExists(aCCFixedAssets.Id))
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
            return View(aCCFixedAssets);
        }

        // GET: ACCFixedAssets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCCFixedAssets = await _context.ACCFixedAssets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aCCFixedAssets == null)
            {
                return NotFound();
            }

            return View(aCCFixedAssets);
        }

        // POST: ACCFixedAssets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aCCFixedAssets = await _context.ACCFixedAssets.FindAsync(id);
            _context.ACCFixedAssets.Remove(aCCFixedAssets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ACCFixedAssetsExists(int id)
        {
            return _context.ACCFixedAssets.Any(e => e.Id == id);
        }
    }
}
