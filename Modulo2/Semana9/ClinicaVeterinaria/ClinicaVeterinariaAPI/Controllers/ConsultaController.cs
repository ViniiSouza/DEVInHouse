using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinariaAPI.Controllers
{
    [ApiController]
    [Route("consulta")]
    public class ConsultaController : ControllerBase
    {
        /// <summary>
        /// Retorna a lista de consultas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Consulta> Get()
        {
            return new List<Consulta>();
        }

        /// <summary>
        ///  Retorna a consulta do id <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Consulta GetById(int id)
        {
            return new Consulta();
        }

        /// <summary>
        /// Cria uma consulta <paramref name="consulta"/>
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Consulta Post(Consulta consulta)
        {
            return consulta;
        }

        /// <summary>
        /// Altera a consulta <paramref name="consulta"/>
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Consulta Put(Consulta consulta)
        {
            return consulta;
        }

        /// <summary>
        /// Deleta a consulta de id <paramref name="id"/>
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
