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
    public class ProgramController : ControllerBase
    {
        private readonly CISVContext _context;

        public ProgramController(CISVContext context)
        {
            _context = context;
        }

        // GET: api/Program
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prog>>> GetProg()
        {
            return await _context.Prog.ToListAsync();
        }

        // GET: api/Program/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prog>> GetProg(int id)
        {
            var prog = await _context.Prog.FindAsync(id);

            if (prog == null)
            {
                return NotFound();
            }

            return prog;
        }

        // PUT: api/Program/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProg(int id, Prog prog)
        {
            if (id != prog.ProgId)
            {
                return BadRequest();
            }

            _context.Entry(prog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgExists(id))
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

        // POST: api/Program
        [HttpPost]
        public async Task<ActionResult<Prog>> PostProg(Prog prog)
        {
            _context.Prog.Add(prog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProg", new { id = prog.ProgId }, prog);
        }

        // DELETE: api/Program/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Prog>> DeleteProg(int id)
        {
            var prog = await _context.Prog.FindAsync(id);
            if (prog == null)
            {
                return NotFound();
            }

            _context.Prog.Remove(prog);
            await _context.SaveChangesAsync();

            return prog;
        }

        private bool ProgExists(int id)
        {
            return _context.Prog.Any(e => e.ProgId == id);
        }
    }
}
