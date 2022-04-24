namespace CodeFirst_11.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public float Preco { get; set; }

        public string Motor { get; set; }

        public long Km { get; set; }

        public int idCliente { get; set; }

        public Cliente Cliente { get; set; }
    }
}
