using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Veterinario
    {
        public Veterinario()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
