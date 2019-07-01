using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CISVContacts;

namespace CISVContacts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContsController : ControllerBase
    {
        private readonly CISVContext _context;

        public ContsController(CISVContext context)
        {
            _context = context;
        }

        // GET: api/Conts
        [HttpGet]
        public IEnumerable<Cont> GetCont()
        {
            return _context.Cont;
        }

        // GET: api/Conts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCont([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cont = await _context.Cont.FindAsync(id);

            if (cont == null)
            {
                return NotFound();
            }

            return Ok(cont);
        }

        // PUT: api/Conts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCont([FromRoute] int id, [FromBody] Cont cont)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cont.ContId)
            {
                return BadRequest();
            }

            _context.Entry(cont).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContExists(id))
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

        // POST: api/Conts
        [HttpPost]
        public async Task<IActionResult> PostCont([FromBody] Cont cont)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cont.Add(cont);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCont", new { id = cont.ContId }, cont);
        }

        // DELETE: api/Conts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCont([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cont = await _context.Cont.FindAsync(id);
            if (cont == null)
            {
                return NotFound();
            }

            _context.Cont.Remove(cont);
            await _context.SaveChangesAsync();

            return Ok(cont);
        }

        private bool ContExists(int id)
        {
            return _context.Cont.Any(e => e.ContId == id);
        }
    }
}