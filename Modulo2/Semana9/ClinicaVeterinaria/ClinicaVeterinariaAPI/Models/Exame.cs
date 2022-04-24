using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinariaAPI.Models
{
    public class Exame
    {
        [Key]
        public int Id { get; set; }

        public int idConsulta { get; set; }

        [StringLength(250)]
        public string Descricao { get; set; }
    }
}
