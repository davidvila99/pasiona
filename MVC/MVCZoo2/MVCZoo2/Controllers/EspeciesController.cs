using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCZoo2.Models;

namespace MVCZoo2.Controllers
{
    public class EspeciesController : Controller
    {
        private readonly MVCZoo2Context _context;

        public EspeciesController(MVCZoo2Context context)
        {
            _context = context;
        }

        // GET: Especies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Especies.ToListAsync());
        }

        // GET: Especies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especie = await _context.Especies
                .Include(c => c.ViveEns)
                .ThenInclude(Vive_ens => Vive_ens.Habitat)
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewData["ListaHabitat"] = new SelectList(_context.Habitats, "Id", "Nombre");
            if (especie == null)
            {
                return NotFound();
            }

            return View(especie);
        }

        // GET: Especies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Especies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Foto,NombreCompuesto,NombreCientifico,Descripcion")] Especie especie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(especie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddHabitats(int id, [Bind("HabitatId,Indice")] ViveEn viveEn)
        {
            viveEn.EspecieId = id;

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

        // GET: Especies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especie = await _context.Especies.FindAsync(id);
            if (especie == null)
            {
                return NotFound();
            }
            return View(especie);
        }


        // POST: Especies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Foto,NombreCompuesto,NombreCientifico,Descripcion")] Especie especie)
        {
            if (id != especie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecieExists(especie.Id))
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
            return View(especie);
        }

        public ActionResult AddPhoto(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPhoto(int id, IFormFile Photo)
        {
            if (Photo != null && Photo.Length > 0)
            {

                var fileName = id + ".jpg";

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }

            }
            return RedirectToAction("Details", new { Id = id });
        }

        // GET: Especies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especie = await _context.Especies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especie == null)
            {
                return NotFound();
            }

            return View(especie);
        }

        // POST: Especies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var especie = await _context.Especies.FindAsync(id);
            _context.Especies.Remove(especie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecieExists(int id)
        {
            return _context.Especies.Any(e => e.Id == id);
        }
    }
}
