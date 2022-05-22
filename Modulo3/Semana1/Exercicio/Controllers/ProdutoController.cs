using AutoMapper;
using Ex1.DTOs;
using Ex1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ex1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly Modulo3Semana1Context _context;
        private readonly IMapper _mapper;
        
        public ProdutoController(Modulo3Semana1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Produto.ToList();
            return Ok(_mapper.Map<List<ProdutoDTO>>(products));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _context.Produto.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ProdutoDTO>(produto));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProdutoDTO produto)
        {
            var produtoEntity = _mapper.Map<Produto>(produto);
            _context.Produto.Add(produtoEntity);
            _context.SaveChanges();
            return Ok(new
            {
                NomeProduto = produto.NomeProduto,
                ValorProduto = produto.ValorProduto
            });
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ProdutoDTO produto, [FromRoute] int id)
        {
            produto.Id = id;
            var produtoEntity = _mapper.Map<Produto>(produto);
            _context.Produto.Update(produtoEntity);
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
