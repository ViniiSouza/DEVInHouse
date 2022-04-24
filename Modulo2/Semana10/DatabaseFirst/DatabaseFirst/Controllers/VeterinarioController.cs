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
    public class VeterinarioController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public VeterinarioController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna a lista de veterinários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();
        }

        /// <summary>
        /// Retorna o veterinário com o id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Veterinario>> GetVeterinario(int id)
        {
            var veterinario = await _context.Veterinarios.FindAsync(id);

            if (veterinario == null)
            {
                return NotFound();
            }

            return veterinario;
        }

        /// <summary>
        /// Altera o veterinário recebido
        /// </summary>
        /// <param name="id"></param>
        /// <param name="veterinario"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutVeterinario(int id, Veterinario veterinario)
        {
            if (id != veterinario.Id)
            {
                return BadRequest();
            }

            _context.Entry(veterinario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeterinarioExists(id))
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
        /// Adiciona um novo veterinário
        /// </summary>
        /// <param name="veterinario"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Veterinario>> PostVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVeterinario", new { id = veterinario.Id }, veterinario);
        }

        /// <summary>
        /// Exclui o veterinário do id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteVeterinario(int id)
        {
            var veterinario = await _context.Veterinarios.FindAsync(id);
            if (veterinario == null)
            {
                return NotFound();
            }

            _context.Veterinarios.Remove(veterinario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VeterinarioExists(int id)
        {
            return _context.Veterinarios.Any(e => e.Id == id);
        }
    }
}
