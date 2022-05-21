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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _context.Produto.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
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

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Produto produto, [FromRoute] int id)
        {
            produto.Id = id;
            _context.Produto.Update(produto);
            _context.SaveChanges();
            return Ok(new
            {
                NomeProduto = produto.NomeProduto,
                ValorProduto = produto.ValorProduto
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _context.Produto.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            _context.Produto.Remove(produto);
            _context.SaveChanges();
            return Ok(new
            {
                NomeProduto = produto.NomeProduto,
                ValorProduto = produto.ValorProduto
            });
        }
    }
}
