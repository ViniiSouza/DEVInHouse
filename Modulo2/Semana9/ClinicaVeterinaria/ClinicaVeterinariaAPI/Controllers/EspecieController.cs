using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClinicaVeterinariaAPI.Controllers
{
    [ApiController]
    [Route("especie")]
    public class EspecieController : ControllerBase
    {
        /// <summary>
        /// Retorna a lista de espécies
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Especie> Get()
        {
            return new List<Especie>();
        }

        /// <summary>
        /// Retorna a espécie de id <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Especie GetById(int id)
        {
            return new Especie();
        }

        /// <summary>
        /// Cria uma nova espécie <paramref name="especie"/>
        /// </summary>
        /// <param name="especie"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Especie Post(Especie especie)
        {
            return especie;
        }

        /// <summary>
        /// Altera a espécie <paramref name="especie"/>
        /// </summary>
        /// <param name="especie"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Especie Put(Especie especie)
        {
            return especie;
        }


        /// <summary>
        /// Exclui a espécie de id <paramref name="id"/>
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
