using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Applikacio2;

namespace Applikacio2.Controllers
{
    public class EsemenysController : Controller
    {
        private readonly registryContext _context;

        public EsemenysController(registryContext context)
        {
            _context = context;
        }

        // GET: Esemenys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Esemenies.ToListAsync());
        }

        // GET: Esemenys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esemeny = await _context.Esemenies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (esemeny == null)
            {
                return NotFound();
            }

            return View(esemeny);
        }

        // GET: Esemenys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Esemenys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] Esemeny esemeny)
        {
            if (ModelState.IsValid)
            {
                _context.Add(esemeny);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(esemeny);
        }

        // GET: Esemenys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esemeny = await _context.Esemenies.FindAsync(id);
            if (esemeny == null)
            {
                return NotFound();
            }
            return View(esemeny);
        }

        // POST: Esemenys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] Esemeny esemeny)
        {
            if (id != esemeny.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(esemeny);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EsemenyExists(esemeny.Id))
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
            return View(esemeny);
        }

        // GET: Esemenys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var esemeny = await _context.Esemenies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (esemeny == null)
            {
                return NotFound();
            }

            return View(esemeny);
        }

        // POST: Esemenys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var esemeny = await _context.Esemenies.FindAsync(id);
            _context.Esemenies.Remove(esemeny);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EsemenyExists(int id)
        {
            return _context.Esemenies.Any(e => e.Id == id);
        }
    }
}
