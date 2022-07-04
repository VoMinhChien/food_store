using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;
using asmC5.Models;

namespace Assignment.Controllers
{
    public class CategoryModelsController : Controller
    {
        private readonly DataContext _context;

        public CategoryModelsController(DataContext context)
        {
            _context = context;
        }

        // GET: CategoryModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoryModels.ToListAsync());
        }

        // GET: CategoryModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModels = await _context.CategoryModels
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (categoryModels == null)
            {
                return NotFound();
            }

            return View(categoryModels);
        }

        // GET: CategoryModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoryModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategorName")] CategoryModels categoryModels)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryModels);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryModels);
        }

        // GET: CategoryModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModels = await _context.CategoryModels.FindAsync(id);
            if (categoryModels == null)
            {
                return NotFound();
            }
            return View(categoryModels);
        }

        // POST: CategoryModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategorName")] CategoryModels categoryModels)
        {
            if (id != categoryModels.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryModels);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryModelsExists(categoryModels.CategoryId))
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
            return View(categoryModels);
        }

        // GET: CategoryModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModels = await _context.CategoryModels
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (categoryModels == null)
            {
                return NotFound();
            }

            return View(categoryModels);
        }

        // POST: CategoryModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryModels = await _context.CategoryModels.FindAsync(id);
            _context.CategoryModels.Remove(categoryModels);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryModelsExists(int id)
        {
            return _context.CategoryModels.Any(e => e.CategoryId == id);
        }
    }
}
