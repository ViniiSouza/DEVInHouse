using System.ComponentModel.DataAnnotations;

namespace Ex1.DTOs
{
    public class ProdutoDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string NomeProduto { get; set; }

        [Required]
        public float ValorProduto { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataCompra { get; set; }
    }
}
