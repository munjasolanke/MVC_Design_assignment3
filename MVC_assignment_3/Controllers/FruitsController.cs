using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_assignment_3.Data;
using MVC_assignment_3.Models;

namespace MVC_assignment_3.Controllers
{
    public class FruitsController : Controller
    {
        private readonly MVCFruits _context;

        public FruitsController(MVCFruits context)
        {
            _context = context;
        }

        // GET: Fruits
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fruits.ToListAsync());
        }

        // GET: Fruits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fruits = await _context.Fruits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fruits == null)
            {
                return NotFound();
            }

            return View(fruits);
        }

        // GET: Fruits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fruits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FruitName,FruitForm,AvgRetailPrice,PreparationYieldFactor,Sizeofcupequivalent,AvgPricepercupequivalent")] Fruits fruits)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fruits);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fruits);
        }

        // GET: Fruits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fruits = await _context.Fruits.FindAsync(id);
            if (fruits == null)
            {
                return NotFound();
            }
            return View(fruits);
        }

        // POST: Fruits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FruitName,FruitForm,AvgRetailPrice,PreparationYieldFactor,Sizeofcupequivalent,AvgPricepercupequivalent")] Fruits fruits)
        {
            if (id != fruits.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fruits);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FruitsExists(fruits.Id))
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
            return View(fruits);
        }

        // GET: Fruits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fruits = await _context.Fruits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fruits == null)
            {
                return NotFound();
            }

            return View(fruits);
        }

        // POST: Fruits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fruits = await _context.Fruits.FindAsync(id);
            _context.Fruits.Remove(fruits);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FruitsExists(int id)
        {
            return _context.Fruits.Any(e => e.Id == id);
        }
    }
}
