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
    public class EspecieController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public EspecieController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna a lista de espécies
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Especie>>> GetEspecies()
        {
            return await _context.Especies.ToListAsync();
        }

        /// <summary>
        /// Retornar a espécie com o id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Especie>> GetEspecie(int id)
        {
            var especie = await _context.Especies.FindAsync(id);

            if (especie == null)
            {
                return NotFound();
            }

            return especie;
        }

        /// <summary>
        /// Altera a consulta recebida
        /// </summary>
        /// <param name="id"></param>
        /// <param name="especie"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutEspecie(int id, Especie especie)
        {
            if (id != especie.Id)
            {
                return BadRequest();
            }

            _context.Entry(especie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecieExists(id))
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
        /// Adiciona uma nova espécie
        /// </summary>
        /// <param name="especie"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Especie>> PostEspecie(Especie especie)
        {
            _context.Especies.Add(especie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecie", new { id = especie.Id }, especie);
        }

        /// <summary>
        /// Exclui a espécie do id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteEspecie(int id)
        {
            var especie = await _context.Especies.FindAsync(id);
            if (especie == null)
            {
                return NotFound();
            }

            _context.Especies.Remove(especie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EspecieExists(int id)
        {
            return _context.Especies.Any(e => e.Id == id);
        }
    }
}
