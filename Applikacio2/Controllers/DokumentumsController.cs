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
    public class DokumentumsController : Controller
    {
        private readonly registryContext _context;

        public DokumentumsController(registryContext context)
        {
            _context = context;
        }

        // GET: Dokumentums
        public async Task<IActionResult> Index(string searchString)
        {
            var documents = from d in _context.Dokumenta
                            where d.MainId != 0
                            orderby d.Id
                            ascending
                            select d;

            //var documents = _context.Documents.Where(d => d.MainID != 0).OrderBy(d => d.ID).ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {

                //documents = documents.Where(s => s.Title.Contains(searchString));

                documents = from s in documents
                            where s.Title.Contains(searchString)
                            orderby s.Id
                            select s;

            }
            //return View(await _context.Documents.Where(d => d.MainID != 0).OrderBy(d => d.ID).ToListAsync());
            return View(await documents.ToListAsync());
            //return View(await _context.Dokumenta.ToListAsync());
        }
        // GET: Documents/Children/5 (Document's Children)
        public async Task<IActionResult> Children(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Dokumenta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(await _context.Dokumenta.Where(d => d.MainId == document.Id).OrderBy(d => d.Id).ToListAsync());
        }
        // GET: Dokumentums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dokumentum = await _context.Dokumenta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dokumentum == null)
            {
                return NotFound();
            }

            return View(dokumentum);
        }

        // GET: Dokumentums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dokumentums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Extension,MainId,Source")] Dokumentum dokumentum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dokumentum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dokumentum);
        }

        // GET: Dokumentums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dokumentum = await _context.Dokumenta.FindAsync(id);
            if (dokumentum == null)
            {
                return NotFound();
            }
            return View(dokumentum);
        }

        // POST: Dokumentums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Extension,MainId,Source")] Dokumentum dokumentum)
        {
            if (id != dokumentum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dokumentum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DokumentumExists(dokumentum.Id))
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
            return View(dokumentum);
        }

        // GET: Dokumentums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dokumentum = await _context.Dokumenta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dokumentum == null)
            {
                return NotFound();
            }

            return View(dokumentum);
        }

        // POST: Dokumentums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dokumentum = await _context.Dokumenta.FindAsync(id);
            _context.Dokumenta.Remove(dokumentum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DokumentumExists(int id)
        {
            return _context.Dokumenta.Any(e => e.Id == id);
        }
    }
}
