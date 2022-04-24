using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinariaAPI.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [StringLength(200)]
        [Required]
        public string Endereco { get; set; }

        [StringLength(50)]
        [Required]
        public string Bairro { get; set; }

        public float CEP { get; set; }

        [StringLength(100)]
        [Required]
        public string Cidade { get; set; }

        [StringLength(35)]
        [Required]
        public string Telefone { get; set; }
    }
}
