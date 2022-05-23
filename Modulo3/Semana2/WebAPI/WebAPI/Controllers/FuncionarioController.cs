using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "administrador")]
        public IActionResult CadastrarNovoFuncionario(Funcionario funcionario)
        {
            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        [Route("excluir-funcionario")]
        [Authorize(Roles = "administrador, gerente")]
        public IActionResult ExcluirFuncionario([FromRoute] int id)
        {
            return Accepted();
        }

        [HttpDelete("{id}")]
        [Route("excluir-gerente")]
        [Authorize(Roles = "administrador")]
        public IActionResult ExcluirGerente([FromRoute] int id)
        {
            return Accepted();
        }

        [HttpPut]
        [Route("alterar-salario")]
        [Authorize(Roles = "gerente")]
        public IActionResult AlterarSalario()
        {
            return Ok();
        }

        [HttpGet]
        [Route("listar")]
        [Authorize]
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
