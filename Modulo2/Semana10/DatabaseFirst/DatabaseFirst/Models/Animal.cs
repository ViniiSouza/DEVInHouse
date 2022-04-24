using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Animal
    {
        public Animal()
        {
            Especies = new HashSet<Especie>();
            Tratamentos = new HashSet<Tratamento>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public string? Sexo { get; set; }
        public int? IdEspecie { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Especie? IdEspecieNavigation { get; set; }
        public virtual ICollection<Especie> Especies { get; set; }
        public virtual ICollection<Tratamento> Tratamentos { get; set; }
    }
}
