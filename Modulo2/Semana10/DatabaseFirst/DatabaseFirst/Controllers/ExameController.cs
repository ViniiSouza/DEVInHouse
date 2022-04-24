#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseFirst.Context;
using DatabaseFirst.Models;

namespace DatabaseFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public ExameController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna a lista de exames
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Exame>>> GetExames()
        {
            return await _context.Exames.ToListAsync();
        }

        /// <summary>
        /// Retorna o exame com o id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Exame>> GetExame(int id)
        {
            var exame = await _context.Exames.FindAsync(id);

            if (exame == null)
            {
                return NotFound();
            }

            return exame;
        }

        /// <summary>
        /// Altera o exame recebido
        /// </summary>
        /// <param name="id"></param>
        /// <param name="exame"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutExame(int id, Exame exame)
        {
            if (id != exame.Id)
            {
                return BadRequest();
            }

            _context.Entry(exame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExameExists(id))
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

        /// <summary>
        /// Adiciona um novo exame
        /// </summary>
        /// <param name="exame"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Exame>> PostExame(Exame exame)
        {
            _context.Exames.Add(exame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExame", new { id = exame.Id }, exame);
        }

        /// <summary>
        /// Exclui o exame do id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteExame(int id)
        {
            var exame = await _context.Exames.FindAsync(id);
            if (exame == null)
            {
                return NotFound();
            }

            _context.Exames.Remove(exame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExameExists(int id)
        {
            return _context.Exames.Any(e => e.Id == id);
        }
    }
}
