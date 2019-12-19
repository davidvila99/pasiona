using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_FinalProject.Models;

namespace API_FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameStuffsController : ControllerBase
    {
        private readonly API_FinalProjectContext _context;

        public GameStuffsController(API_FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/GameStuffs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameStuff>>> GetGameStuff()
        {
            return await _context.GameStuff.ToListAsync();
        }

        // GET: api/GameStuffs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameStuff>> GetGameStuff(int id)
        {
            var gameStuff = await _context.GameStuff.FindAsync(id);

            if (gameStuff == null)
            {
                return NotFound();
            }

            return gameStuff;
        }

        // PUT: api/GameStuffs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameStuff(int id, GameStuff gameStuff)
        {
            if (id != gameStuff.Id)
            {
                return BadRequest();
            }

            _context.Entry(gameStuff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameStuffExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GameStuffs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<GameStuff>> PostGameStuff(GameStuff gameStuff)
        {
            _context.GameStuff.Add(gameStuff);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameStuff", new { id = gameStuff.Id }, gameStuff);
        }

        // DELETE: api/GameStuffs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GameStuff>> DeleteGameStuff(int id)
        {
            var gameStuff = await _context.GameStuff.FindAsync(id);
            if (gameStuff == null)
            {
                return NotFound();
            }

            _context.GameStuff.Remove(gameStuff);
            await _context.SaveChangesAsync();

            return gameStuff;
        }

        private bool GameStuffExists(int id)
        {
            return _context.GameStuff.Any(e => e.Id == id);
        }
    }
}
