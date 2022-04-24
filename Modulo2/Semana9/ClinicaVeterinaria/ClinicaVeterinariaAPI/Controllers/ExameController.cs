using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClinicaVeterinariaAPI.Controllers
{
    [ApiController]
    [Route("exame")]
    public class ExameController : ControllerBase
    {
        /// <summary>
        /// Retorna a lista de exames
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Exame> Get()
        {
            return new List<Exame>();
        }

        /// <summary>
        /// Retorna o exame de id <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Exame GetById(int id)
        {
            return new Exame();
        }

        /// <summary>
        /// Cria um exame <paramref name="exame"/>
        /// </summary>
        /// <param name="exame"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Exame Post(Exame exame)
        {
            return exame;
        }

        /// <summary>
        /// Altera um exame <paramref name="exame"/>
        /// </summary>
        /// <param name="exame"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Exame Put(Exame exame)
        {
            return exame;
        }

        /// <summary>
        /// Exclui um exame de id <paramref name="id"/>
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
