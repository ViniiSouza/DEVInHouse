using Ex1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ex1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly Modulo3Semana1Context _context;
        
        public ProdutoController(Modulo3Semana1Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Produto.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
            return Ok(new
            {
                NomeProduto = produto.NomeProduto,
                ValorProduto = produto.ValorProduto
            });
        }
    }
}
