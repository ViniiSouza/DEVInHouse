using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinariaAPI.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public int Idade { get; set; }

        [StringLength(15)]
        public string Sexo { get; set; }


        public int idEspecie { get; set; }

        public int idCliente { get; set; }
    }
}
