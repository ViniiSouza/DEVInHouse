using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClinicaVeterinariaAPI.Controllers
{
    [ApiController]
    [Route("veterinario")]
    public class VeterinarioController : ControllerBase
    {
        /// <summary>
        /// Retorna a lista de veterinários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Veterinario> Get()
        {
            return new List<Veterinario>();
        }

        /// <summary>
        /// Retorna o veterinário com o id <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Veterinario GetById(int id)
        {
            return new Veterinario();
        }

        /// <summary>
        /// Cria um novo veterinário <paramref name="veterinario"/>
        /// </summary>
        /// <param name="veterinario"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Veterinario Post(Veterinario veterinario)
        {
            return veterinario;
        }

        /// <summary>
        /// Altera o veterinário <paramref name="veterinario"/>
        /// </summary>
        /// <param name="veterinario"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Veterinario Put(Veterinario veterinario)
        {
            return veterinario;
        }

        /// <summary>
        /// Exclui o veterinário com o id <paramref name="id"/>
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
