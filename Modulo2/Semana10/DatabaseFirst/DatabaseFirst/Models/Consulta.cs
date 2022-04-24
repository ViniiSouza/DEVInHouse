using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Consulta
    {
        public Consulta()
        {
            Exames = new HashSet<Exame>();
        }

        public int Id { get; set; }
        public int? IdTratamento { get; set; }
        public int? IdVeterinario { get; set; }
        public DateTime? Data { get; set; }
        public string? Historico { get; set; }

        public virtual Tratamento? IdTratamentoNavigation { get; set; }
        public virtual Veterinario? IdVeterinarioNavigation { get; set; }
        public virtual ICollection<Exame> Exames { get; set; }
    }
}
