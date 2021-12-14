using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Applikacio2;
using Microsoft.AspNetCore.Http;
using System.Dynamic;
using Applikacio2.Models;

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


            if (!String.IsNullOrEmpty(searchString))
            {

                return RedirectToAction(nameof(FilteredIndex), new { searchString = searchString });
            }
           
            if (HttpContext.Session.GetString("username") != null)
            {
                return View(await documents.ToListAsync());
            }
            return View("Empty");
            
        }

        public async Task<IActionResult> FilteredIndex(string searchString)
        {
            if (HttpContext.Session.GetString("username") != null)
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

                documents = documents.Where(s => s.Title.Contains(searchString));

                return View(await documents.ToListAsync());
            }
            return View("Empty");
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

            //EventsListed
            IQueryable<ListedEvent> events = GetEvents(id);

            //ChildrenListed
            var children =
                from d in _context.Dokumenta
                join n in _context.Naplos on d.Id equals n.DokumentumId
                join e in _context.Esemenies on n.EsemenyId equals e.Id
                where d.MainId == document.Id
                && e.Title == "Letrehozas"
                orderby n.HappenedAt
                ascending
                select d;

            var Events = await events.ToListAsync();
            var Children = await children.ToListAsync();

            ViewBag.Message = "Welcome to my demo!";
            ViewData["Events"] = Events;
            ViewData["Children"] = Children;


            if (document == null)
            {
                return NotFound();
            }

            return View();
        }

        private dynamic GetTeachers()
        {
            throw new NotImplementedException();
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

        public async Task<IActionResult> Events(int? id)
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
            IQueryable<ListedEvent> events = GetEvents(id);

            return View(await events.ToListAsync());
        }

        private IQueryable<ListedEvent> GetEvents(int? id)
        {
            return from e in _context.Esemenies
                   join n in _context.Naplos on e.Id equals n.EsemenyId
                   join d in _context.Dokumenta on n.DokumentumId equals d.Id
                   where d.Id == id
                   orderby n.HappenedAt
                   select new ListedEvent
                   {
                       Event = e.Title,
                       Date = n.HappenedAt
                   };
        }
    }
}
