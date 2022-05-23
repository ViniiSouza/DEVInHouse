using Microsoft.AspNetCore.Mvc;
using RH.Models;

namespace RH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacaoController: ControllerBase
    {
        // post requisition called Login that return a valid JWT token
        [HttpPost]
        [Route("login")]
        public IActionResult Login(Funcionario funcionario)
        {
            return Ok(TokenService.GerarToken(funcionario));
        }
    }
}
