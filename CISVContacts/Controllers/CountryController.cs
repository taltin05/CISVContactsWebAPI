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
    public class CountryController : ControllerBase
    {
        private readonly CISVContext _context;

        public CountryController(CISVContext context)
        {
            _context = context;
        }

        // GET: api/Country
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coun>>> GetCountry()
        {
            return await _context.Coun.OrderBy(c => c.Country).ToListAsync();
        }

        // GET: api/Country/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coun>> GetCountry(string id)
        {
            var coun = await _context.Coun.FindAsync(id);

            if (coun == null)
            {
                return NotFound();
            }

            return coun;
        }

        // PUT: api/Country/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoun(string id, Coun coun)
        {
            if (id != coun.CounCode)
            {
                return BadRequest();
            }

            _context.Entry(coun).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounExists(id))
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

        // POST: api/Country
        [HttpPost]
        public async Task<ActionResult<Coun>> PostCoun(Coun coun)
        {
            _context.Coun.Add(coun);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CounExists(coun.CounCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCoun", new { id = coun.CounCode }, coun);
        }

        // DELETE: api/Country/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Coun>> DeleteCoun(string id)
        {
            var coun = await _context.Coun.FindAsync(id);
            if (coun == null)
            {
                return NotFound();
            }

            _context.Coun.Remove(coun);
            await _context.SaveChangesAsync();

            return coun;
        }

        private bool CounExists(string id)
        {
            return _context.Coun.Any(e => e.CounCode == id);
        }
    }
}
