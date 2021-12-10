using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Applikacio2;
using Microsoft.AspNetCore.Http;

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

            var documents =
                from d in _context.Dokumenta
                join n in _context.Naplos on d.Id equals n.DokumentumId
                join e in _context.Esemenies on n.EsemenyId equals e.Id
                where d.MainId == 0
                && e.Title == "Beerkezes"
                orderby n.HappenedAt
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
            if (HttpContext.Session.GetString("username") != null)
            {
                return View(await documents.ToListAsync());
            }
            return View("Empty");
            //return View(await _context.Dokumenta.ToListAsync());
        }
        // GET: Documents/Children/5 (Document's Children)
        public async Task<IActionResult> Children(int? id)
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return View("Empty");
            }
            
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Dokumenta
                .FirstOrDefaultAsync(m => m.Id == id);

            var events = from e in _context.Esemenies
                         join n in _context.Naplos on e.Id equals n.EsemenyId
                         join d in _context.Dokumenta on n.DokumentumId equals d.Id
                         where d == document
                         orderby n.HappenedAt
                         select e;

            var children =
                from d in _context.Dokumenta
                join n in _context.Naplos on d.Id equals n.DokumentumId
                join e in _context.Esemenies on n.EsemenyId equals e.Id
                where d.MainId == document.Id
                && e.Title == "Letrehozas"
                orderby n.HappenedAt
                ascending
                select d;

            if (document == null)
            {
                return NotFound();
            }

            return View(await _context.Dokumenta.Where(d => d.MainId == document.Id).OrderBy(d => d.Id).ToListAsync());
        }
        // GET: Dokumentums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return View("Empty");
            }
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

    }
}
