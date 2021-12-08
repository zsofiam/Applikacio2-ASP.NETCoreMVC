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
    public class NaplosController : Controller
    {
        private readonly registryContext _context;

        public NaplosController(registryContext context)
        {
            _context = context;
        }

        // GET: Naplos
        public async Task<IActionResult> Index()
        {
            var registryContext = _context.Naplos.Include(n => n.Dokumentum).Include(n => n.Esemeny);
            return View(await registryContext.ToListAsync());
        }

        // GET: Naplos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naplo = await _context.Naplos
                .Include(n => n.Dokumentum)
                .Include(n => n.Esemeny)
                .FirstOrDefaultAsync(m => m.DokumentumId == id);
            if (naplo == null)
            {
                return NotFound();
            }

            return View(naplo);
        }

        // GET: Naplos/Create
        public IActionResult Create()
        {
            ViewData["DokumentumId"] = new SelectList(_context.Dokumenta, "Id", "Extension");
            ViewData["EsemenyId"] = new SelectList(_context.Esemenies, "Id", "Title");
            return View();
        }

        // POST: Naplos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DokumentumId,EsemenyId,HappenedAt")] Naplo naplo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(naplo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DokumentumId"] = new SelectList(_context.Dokumenta, "Id", "Extension", naplo.DokumentumId);
            ViewData["EsemenyId"] = new SelectList(_context.Esemenies, "Id", "Title", naplo.EsemenyId);
            return View(naplo);
        }

        // GET: Naplos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naplo = await _context.Naplos.FindAsync(id);
            if (naplo == null)
            {
                return NotFound();
            }
            ViewData["DokumentumId"] = new SelectList(_context.Dokumenta, "Id", "Extension", naplo.DokumentumId);
            ViewData["EsemenyId"] = new SelectList(_context.Esemenies, "Id", "Title", naplo.EsemenyId);
            return View(naplo);
        }

        // POST: Naplos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DokumentumId,EsemenyId,HappenedAt")] Naplo naplo)
        {
            if (id != naplo.DokumentumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(naplo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NaploExists(naplo.DokumentumId))
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
            ViewData["DokumentumId"] = new SelectList(_context.Dokumenta, "Id", "Extension", naplo.DokumentumId);
            ViewData["EsemenyId"] = new SelectList(_context.Esemenies, "Id", "Title", naplo.EsemenyId);
            return View(naplo);
        }

        // GET: Naplos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naplo = await _context.Naplos
                .Include(n => n.Dokumentum)
                .Include(n => n.Esemeny)
                .FirstOrDefaultAsync(m => m.DokumentumId == id);
            if (naplo == null)
            {
                return NotFound();
            }

            return View(naplo);
        }

        // POST: Naplos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var naplo = await _context.Naplos.FindAsync(id);
            _context.Naplos.Remove(naplo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NaploExists(int id)
        {
            return _context.Naplos.Any(e => e.DokumentumId == id);
        }
    }
}
