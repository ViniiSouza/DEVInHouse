using Microsoft.AspNetCore.Mvc;
using RH.Enums;
using RH.Models;

namespace RH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrar-novo-funcionario")]
        public IActionResult CadastrarNovoFuncionario(Funcionario funcionario)
        {
            return Created();
        }

        [HttpDelete("{id}")]
        [Route("excluir-funcionario")]
        public IActionResult ExcluirFuncionario([FromRoute] int id)
        {
            return Accepted();
        }

        [HttpDelete("{id}")]
        [Route("excluir-gerente")]
        public IActionResult ExcluirGerente([FromRoute] int id)
        {
            return Accepted();
        }

        [HttpPut]
        [Route("alterar-salario")]
        public IActionResult AlterarSalario()
        {
            return Ok();
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar(Funcionario funcionario)
        {
            // fazer lógica de listagem
            if (funcionario.Permissao == Permissoes.Gerente || funcionario.Permissao == Permissoes.Administrador)
            {
                return Ok();
            }
            else
            {
                return Ok();
            }
        }
    }
}
