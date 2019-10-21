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
    public class SnacksController : Controller
    {
        private readonly MVCSnacks _context;

        public SnacksController(MVCSnacks context)
        {
            _context = context;
        }

        // GET: Snacks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Snacks.ToListAsync());
        }

        // GET: Snacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snacks = await _context.Snacks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (snacks == null)
            {
                return NotFound();
            }

            return View(snacks);
        }

        // GET: Snacks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Snacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SnackName,PortionSize,PricePerPortion,CaloriesPerPortion")] Snacks snacks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(snacks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(snacks);
        }

        // GET: Snacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snacks = await _context.Snacks.FindAsync(id);
            if (snacks == null)
            {
                return NotFound();
            }
            return View(snacks);
        }

        // POST: Snacks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SnackName,PortionSize,PricePerPortion,CaloriesPerPortion")] Snacks snacks)
        {
            if (id != snacks.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(snacks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SnacksExists(snacks.Id))
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
            return View(snacks);
        }

        // GET: Snacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snacks = await _context.Snacks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (snacks == null)
            {
                return NotFound();
            }

            return View(snacks);
        }

        // POST: Snacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var snacks = await _context.Snacks.FindAsync(id);
            _context.Snacks.Remove(snacks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SnacksExists(int id)
        {
            return _context.Snacks.Any(e => e.Id == id);
        }
    }
}
