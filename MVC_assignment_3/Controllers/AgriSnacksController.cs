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
    public class AgriSnacksController : Controller
    {
        private readonly MVCAgriSnacks _context;

        public AgriSnacksController(MVCAgriSnacks context)
        {
            _context = context;
        }

        // GET: AgriSnacks
        public async Task<IActionResult> Index()
        {
            return View(await _context.AgriSnacks.ToListAsync());
        }

        // GET: AgriSnacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agriSnacks = await _context.AgriSnacks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agriSnacks == null)
            {
                return NotFound();
            }

            return View(agriSnacks);
        }

        // GET: AgriSnacks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AgriSnacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SnackName,PortionSize,PricePerPortion,CaloriesPerPortion")] AgriSnacks agriSnacks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agriSnacks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agriSnacks);
        }

        // GET: AgriSnacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agriSnacks = await _context.AgriSnacks.FindAsync(id);
            if (agriSnacks == null)
            {
                return NotFound();
            }
            return View(agriSnacks);
        }

        // POST: AgriSnacks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SnackName,PortionSize,PricePerPortion,CaloriesPerPortion")] AgriSnacks agriSnacks)
        {
            if (id != agriSnacks.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agriSnacks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgriSnacksExists(agriSnacks.Id))
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
            return View(agriSnacks);
        }

        // GET: AgriSnacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agriSnacks = await _context.AgriSnacks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agriSnacks == null)
            {
                return NotFound();
            }

            return View(agriSnacks);
        }

        // POST: AgriSnacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agriSnacks = await _context.AgriSnacks.FindAsync(id);
            _context.AgriSnacks.Remove(agriSnacks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgriSnacksExists(int id)
        {
            return _context.AgriSnacks.Any(e => e.Id == id);
        }
    }
}
