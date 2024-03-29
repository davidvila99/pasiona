﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JuanPabloWeba.Models;
using JuanPabloWeba.DTO;

namespace JuanPabloWeba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly JuanPabloWebaContext _context;

        public CategoriesController(JuanPabloWebaContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public IEnumerable<DTOCategory> GetCategories()
        {
            var cats = from c in _context.Categories.Include(c => c.Games)
                       select new DTOCategory()
                       {
                           Name = c.Name,
                           NumGames = c.Games.Count
                       };
            return cats;
        }

        [HttpGet("[action]/{Nombre}")]
        public IEnumerable<Category> Find(String Nombre) {
            return _context.Categories.Where(c => c.Name.Contains(Nombre)).ToList();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = await _context.Categories.Include(g => g.Games)
                .FirstOrDefaultAsync(m => m.Id == id);

            DTOCategory dTOCategory = new DTOCategory() { Name = category.Name, NumGames = category.Games.Count };

            if (category == null)
            {
                return NotFound();
            }

            return Ok(dTOCategory);
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory([FromRoute] int id, [FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != category.Id)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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

        // POST: api/Categories
        [HttpPost]
        public async Task<IActionResult> PostCategory([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}