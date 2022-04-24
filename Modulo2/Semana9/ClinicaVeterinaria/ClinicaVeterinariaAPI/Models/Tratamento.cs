using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinariaAPI.Models
{
    public class Tratamento
    {
        [Key]
        public int Id { get; set; }

        public int idAnimal { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }
    }
}
