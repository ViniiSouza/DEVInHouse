using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinariaAPI.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }

        public int idTratamento { get; set; }

        public int idVeterinario { get; set; }

        public DateTime Data { get; set; }

        [StringLength(500)]
        public string Historico { get; set; }
    }
}
