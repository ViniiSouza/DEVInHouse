using CodeFirst_11.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst_11.Controllers
{
    [ApiController]
    [Route("veiculo")]
    public class VeiculoController : ControllerBase
    {
        private readonly ImobiliariaContext _imobiliariaContext;

        public VeiculoController(ImobiliariaContext imobiliariaContext)
        {
            _imobiliariaContext = imobiliariaContext;
        }

        [HttpGet]
        public List<Veiculo> Get()
        {
            return _imobiliariaContext.Veiculo.ToList();
        }

        [HttpGet("{id}")]
        public Veiculo GetById([FromRoute]int id)
        {
            return _imobiliariaContext.Veiculo.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost("create")]
        public Veiculo Create([FromBody] Veiculo veiculo)
        {
            _imobiliariaContext.Veiculo.Add(veiculo);
            _imobiliariaContext.SaveChanges();
            return veiculo;
        }

        [HttpPut("{id}")]
        public Veiculo Update([FromRoute] int id, [FromBody] Veiculo veiculo)
        {
            _imobiliariaContext.Veiculo.Update(veiculo);
            _imobiliariaContext.SaveChanges();
            return veiculo;
        }

        [HttpDelete("{id}")]
        public bool Delete([FromRoute] int id)
        {
            var entity = _imobiliariaContext.Veiculo.FirstOrDefault(x => x.Id==id);
            _imobiliariaContext.Veiculo.Remove(entity);
            return true;
        }
    }
}
