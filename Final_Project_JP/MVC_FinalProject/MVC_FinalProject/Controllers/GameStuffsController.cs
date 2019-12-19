using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_FinalProject.Models;

namespace MVC_FinalProject.Controllers
{
    public class GameStuffsController : Controller
    {
        private readonly MVC_FinalProjectContext _context;

        public GameStuffsController(MVC_FinalProjectContext context)
        {
            _context = context;
        }

        // GET: GameStuffs
        public async Task<IActionResult> Index()
        {
            var mVC_FinalProjectContext = _context.GameStuff.Include(g => g.Player);
            return View(await mVC_FinalProjectContext.ToListAsync());
        }

        // GET: GameStuffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameStuff = await _context.GameStuff
                .Include(g => g.Player)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameStuff == null)
            {
                return NotFound();
            }

            return View(gameStuff);
        }

        // GET: GameStuffs/Create
        public IActionResult Create()
        {
            ViewData["PlayerId"] = new SelectList(_context.Set<Player>(), "Id", "Id");
            return View();
        }

        // POST: GameStuffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameId,PlayerId")] GameStuff gameStuff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameStuff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerId"] = new SelectList(_context.Set<Player>(), "Id", "Id", gameStuff.PlayerId);
            return View(gameStuff);
        }

        // GET: GameStuffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameStuff = await _context.GameStuff.FindAsync(id);
            if (gameStuff == null)
            {
                return NotFound();
            }
            ViewData["PlayerId"] = new SelectList(_context.Set<Player>(), "Id", "Id", gameStuff.PlayerId);
            return View(gameStuff);
        }

        // POST: GameStuffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameId,PlayerId")] GameStuff gameStuff)
        {
            if (id != gameStuff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameStuff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameStuffExists(gameStuff.Id))
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
            ViewData["PlayerId"] = new SelectList(_context.Set<Player>(), "Id", "Id", gameStuff.PlayerId);
            return View(gameStuff);
        }

        // GET: GameStuffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameStuff = await _context.GameStuff
                .Include(g => g.Player)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameStuff == null)
            {
                return NotFound();
            }

            return View(gameStuff);
        }

        // POST: GameStuffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameStuff = await _context.GameStuff.FindAsync(id);
            _context.GameStuff.Remove(gameStuff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameStuffExists(int id)
        {
            return _context.GameStuff.Any(e => e.Id == id);
        }
    }
}
