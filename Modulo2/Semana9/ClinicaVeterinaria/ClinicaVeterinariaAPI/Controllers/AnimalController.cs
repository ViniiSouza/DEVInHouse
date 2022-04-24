using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClinicaVeterinariaAPI.Controllers
{
    [ApiController]
    [Route("animal")]
    public class AnimalController : ControllerBase
    {
        /// <summary>
        /// Retorna a lista de Animais
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Animal> Get()
        {
            return new List<Animal>();
        }

        /// <summary>
        /// Retorna o animal com o id <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Animal GetById(int id)
        {
            var animal = new Animal() { Id = id, Idade = 10, idCliente = 1, idEspecie = 3, Nome = "Leão marinho", Sexo = "F" };
            return animal;
        }

        /// <summary>
        /// Cadastra o animal <paramref name="animal"/>
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Animal Post(Animal animal)
        {
            return animal;
        }

        /// <summary>
        /// Edita o animal <paramref name="animal"/>
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Animal Put(Animal animal)
        {
            return animal;
        }

        /// <summary>
        /// Deleta o animal de id <paramref name="id"/>
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
