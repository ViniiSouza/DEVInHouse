using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinariaAPI.Models
{
    public class Especie
    {
        [Key]
        public int Id { get; set; }

        public int idAnimal { get; set; }

        [StringLength(250)]
        public string Descricao { get; set; }
    }
}
