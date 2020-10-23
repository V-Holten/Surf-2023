using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Surf_2022.Data;
using Surf_2022.Models;

namespace Surf_2022.Controllers
{
    public class SurfspotsController : Controller
    {
        private readonly Surf_2022Context _context;

        public SurfspotsController(Surf_2022Context context)
        {
            _context = context;
        }

        // GET: Surfspots1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Surfspots.ToListAsync());
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: Surfspots1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfspots = await _context.Surfspots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfspots == null)
            {
                return NotFound();
            }

            return View(surfspots);
        }

        // GET: Surfspots1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Surfspots1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Lattitude,Longtitude")] Surfspots surfspots)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surfspots);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(surfspots);
        }

        // GET: Surfspots1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfspots = await _context.Surfspots.FindAsync(id);
            if (surfspots == null)
            {
                return NotFound();
            }
            return View(surfspots);
        }

        // POST: Surfspots1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Lattitude,Longtitude")] Surfspots surfspots)
        {
            if (id != surfspots.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surfspots);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurfspotsExists(surfspots.Id))
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
            return View(surfspots);
        }

        // GET: Surfspots1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfspots = await _context.Surfspots
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfspots == null)
            {
                return NotFound();
            }

            return View(surfspots);
        }

        // POST: Surfspots1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surfspots = await _context.Surfspots.FindAsync(id);
            _context.Surfspots.Remove(surfspots);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurfspotsExists(int id)
        {
            return _context.Surfspots.Any(e => e.Id == id);
        }
    }
}
