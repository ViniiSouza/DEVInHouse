#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseFirst_11.Context;
using DatabaseFirst_11.Models;

namespace DatabaseFirst_11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly BancoContext _context;

        public ContaCorrenteController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/ContaCorrente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaCorrente>>> GetContaCorrentes()
        {
            return await _context.ContaCorrentes.ToListAsync();
        }

        // GET: api/ContaCorrente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaCorrente>> GetContaCorrente(int id)
        {
            var contaCorrente = await _context.ContaCorrentes.FindAsync(id);

            if (contaCorrente == null)
            {
                return NotFound();
            }

            return contaCorrente;
        }

        // PUT: api/ContaCorrente/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContaCorrente(int id, ContaCorrente contaCorrente)
        {
            if (id != contaCorrente.Id)
            {
                return BadRequest();
            }

            _context.Entry(contaCorrente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaCorrenteExists(id))
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

        // POST: api/ContaCorrente
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContaCorrente>> PostContaCorrente(ContaCorrente contaCorrente)
        {
            _context.ContaCorrentes.Add(contaCorrente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContaCorrente", new { id = contaCorrente.Id }, contaCorrente);
        }

        // DELETE: api/ContaCorrente/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContaCorrente(int id)
        {
            var contaCorrente = await _context.ContaCorrentes.FindAsync(id);
            if (contaCorrente == null)
            {
                return NotFound();
            }

            _context.ContaCorrentes.Remove(contaCorrente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContaCorrenteExists(int id)
        {
            return _context.ContaCorrentes.Any(e => e.Id == id);
        }
    }
}
