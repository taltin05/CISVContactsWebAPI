using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CISVContacts.Dto;

namespace CISVContacts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationsController : ControllerBase
    {
        private readonly CISVContext _context;

        public ParticipationsController(CISVContext context)
        {
            _context = context;
        }

        // GET: api/Participations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ppar>>> GetPpar()
        {
            return await _context.Ppar.ToListAsync();
        }

        // GET: api/Participations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ppar>> GetPpar(int id)
        {
            var ppar = await _context.Ppar.FindAsync(id);

            if (ppar == null)
            {
                return NotFound();
            }

            return ppar;
        }

        [HttpGet("ParticipationsByContact/{contactId}")]
        public async Task<ActionResult<IEnumerable<ParticipationContactDto>>> GetParticipationsByContact(int contactId)
        {        
            var result =  from p in _context.Ppar
                          join pr in _context.Prog
                                on p.ProgId equals pr.ProgId
                          join c in _context.Coun 
                                on p.HostCounCode equals c.CounCode
                          into pc
                          from subCountry in pc.DefaultIfEmpty()
                          where p.ContId == contactId
                          select new ParticipationContactDto() 
                          { 
                              PparId = p.PparId,
                              Year = p.Year,                              
                              City = p.HostCity,
                              Program = pr.Program,
                              CountryName = subCountry == null ? String.Empty : subCountry.Country                             
                          };

            return await result.ToListAsync();
        }

        // PUT: api/Participations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPpar(int id, Ppar ppar)
        {
            if (id != ppar.PparId)
            {
                return BadRequest();
            }

            _context.Entry(ppar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PparExists(id))
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

        // POST: api/Participations
        [HttpPost]
        public async Task<ActionResult<Ppar>> PostPpar(Ppar ppar)
        {
            _context.Ppar.Add(ppar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPpar", new { id = ppar.PparId }, ppar);
        }

        // DELETE: api/Participations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ppar>> DeletePpar(int id)
        {
            var ppar = await _context.Ppar.FindAsync(id);
            if (ppar == null)
            {
                return NotFound();
            }

            _context.Ppar.Remove(ppar);
            await _context.SaveChangesAsync();

            return ppar;
        }

        private bool PparExists(int id)
        {
            return _context.Ppar.Any(e => e.PparId == id);
        }
    }
}
