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
    public class TratamentoController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public TratamentoController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna a lista de tratamentos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Tratamento>>> GetTratamentos()
        {
            return await _context.Tratamentos.ToListAsync();
        }

        /// <summary>
        /// Retorna o tratamento com o id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Tratamento>> GetTratamento(int id)
        {
            var tratamento = await _context.Tratamentos.FindAsync(id);

            if (tratamento == null)
            {
                return NotFound();
            }

            return tratamento;
        }

        /// <summary>
        /// Altera o tratamento recebido
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tratamento"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutTratamento(int id, Tratamento tratamento)
        {
            if (id != tratamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(tratamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TratamentoExists(id))
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
        /// Adiciona um novo tratamento
        /// </summary>
        /// <param name="tratamento"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Tratamento>> PostTratamento(Tratamento tratamento)
        {
            _context.Tratamentos.Add(tratamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTratamento", new { id = tratamento.Id }, tratamento);
        }

        /// <summary>
        /// Exclui o tratamento do id fornecido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTratamento(int id)
        {
            var tratamento = await _context.Tratamentos.FindAsync(id);
            if (tratamento == null)
            {
                return NotFound();
            }

            _context.Tratamentos.Remove(tratamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TratamentoExists(int id)
        {
            return _context.Tratamentos.Any(e => e.Id == id);
        }
    }
}
