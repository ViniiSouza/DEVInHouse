using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinariaAPI.Models
{
    public class Veterinario
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(250)]
        public string Endereco { get; set; }

        [StringLength(35)]
        public string Telefone { get; set; }
    }
}
