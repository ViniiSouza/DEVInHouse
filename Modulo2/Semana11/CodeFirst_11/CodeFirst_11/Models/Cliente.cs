namespace CodeFirst_11.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Status { get; set; }

        public Imovel Imovel { get; set; }

        public Veiculo Veiculo { get; set; }
    }
}
