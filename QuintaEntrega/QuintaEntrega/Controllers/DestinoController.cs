using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuintaEntrega.Context;
using QuintaEntrega.Models;

namespace QuintaEntrega.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DestinoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Destino
        [HttpGet]
        [Route("/GetAll")]
        public async Task<ActionResult<IEnumerable<Destino>>> GetDestino()
        {
            return await _context.Destino.ToListAsync();
        }

        // GET: api/Destino/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destino>> GetDestino(int id)
        {
            var destino = await _context.Destino.FindAsync(id);

            if (destino == null)
            {
                return NotFound();
            }

            return destino;
        }

        // PUT: api/Destino/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestino(int id, Destino destino)
        {
            if (id != destino.Id)
            {
                return BadRequest();
            }

            _context.Entry(destino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinoExists(id))
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

        // POST: api/Destino
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destino>> PostDestino(Destino destino)
        {
            _context.Destino.Add(destino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDestino", new { id = destino.Id }, destino);
        }

        // DELETE: api/Destino/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestino(int id)
        {
            var destino = await _context.Destino.FindAsync(id);
            if (destino == null)
            {
                return NotFound();
            }

            _context.Destino.Remove(destino);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinoExists(int id)
        {
            return _context.Destino.Any(e => e.Id == id);
        }
    }
}
