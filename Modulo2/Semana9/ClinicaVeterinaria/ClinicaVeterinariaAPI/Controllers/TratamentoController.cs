using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClinicaVeterinariaAPI.Controllers
{
    [ApiController]
    [Route("tratamento")]
    public class TratamentoController : ControllerBase
    {
        /// <summary>
        /// Retorna a lista de tratamentos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Tratamento> Get()
        {
            return new List<Tratamento>();
        }

        /// <summary>
        /// Retorna o tratamento de id <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Tratamento GetById(int id)
        {
            return new Tratamento();
        }

        /// <summary>
        /// Cria um novo tratamento <paramref name="tratamento"/>
        /// </summary>
        /// <param name="tratamento"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Tratamento Post(Tratamento tratamento)
        {
            return tratamento;
        }

        /// <summary>
        /// Altera o tratamento <paramref name="tratamento"/>
        /// </summary>
        /// <param name="tratamento"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Tratamento Put(Tratamento tratamento)
        {
            return tratamento;
        }

        /// <summary>
        /// Exclui o tratamento de id <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public bool Delete(int id)
        {
            return true;

        }
    }
}
