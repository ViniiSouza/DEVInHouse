using CodeFirst_11.Enumerables;

namespace CodeFirst_11.Models
{
    public class Imovel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string DescricaoCurta { get; set; }

        public string DescricaoLonga { get; set; }


        public Tipo Tipo { get; set; }

        public float Valor { get; set; }

        public Cliente Cliente { get; set; }

        public int idCliente { get; set; }
    }
}
