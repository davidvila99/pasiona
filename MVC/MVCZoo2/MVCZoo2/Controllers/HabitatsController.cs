using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCZoo2.Models;

namespace MVCZoo2.Controllers
{
    public class HabitatsController : Controller
    {
        private readonly MVCZoo2Context _context;

        public HabitatsController(MVCZoo2Context context)
        {
            _context = context;
        }

        // GET: Habitats
        public async Task<IActionResult> Index()
        {
            var mVCZoo2Context = _context.Habitats.Include(h => h.Itinerarios);
            return View(await mVCZoo2Context.ToListAsync());
        }

        // GET: Habitats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitats
                .Include(h => h.Itinerarios)
                .Include(c => c.ViveEns)
                .ThenInclude(ViveEns => ViveEns.Especie)
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewData["ListaEspecie"] = new SelectList(_context.Especies, "Id", "NombreCompuesto");
            if (habitat == null)
            {
                return NotFound();
            }

            return View(habitat);
        }

        // GET: Habitats/Create
        public IActionResult Create()
        {
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo");
            return View();
        }

        // POST: Habitats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Clima,Vegetacion,ItinerarioId")] Habitat habitat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habitat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo", habitat.ItinerarioId);
            return View(habitat);
        }

        // GET: Habitats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitats.FindAsync(id);
            if (habitat == null)
            {
                return NotFound();
            }
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo", habitat.ItinerarioId);
            return View(habitat);
        }

        // POST: Habitats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Clima,Vegetacion,ItinerarioId")] Habitat habitat)
        {
            if (id != habitat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habitat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabitatExists(habitat.Id))
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
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo", habitat.ItinerarioId);
            return View(habitat);
        }

        // GET: Habitats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitats
                .Include(h => h.Itinerarios)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habitat == null)
            {
                return NotFound();
            }

            return View(habitat);
        }

        // POST: Habitats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var habitat = await _context.Habitats.FindAsync(id);
            _context.Habitats.Remove(habitat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEspecie(int id, [Bind("EspecieId,Indice")] ViveEn viveEn)
        {
            viveEn.HabitatId = id;


            try
            {
                _context.Update(viveEn);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                throw;

            }
            return RedirectToAction("Details", new { Id = id });

        }

        private bool HabitatExists(int id)
        {
            return _context.Habitats.Any(e => e.Id == id);
        }
    }
}
