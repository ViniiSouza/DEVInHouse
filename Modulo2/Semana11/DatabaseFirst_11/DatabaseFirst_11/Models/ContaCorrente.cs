using System;
using System.Collections.Generic;

namespace DatabaseFirst_11.Models
{
    public partial class ContaCorrente
    {
        public ContaCorrente()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int Id { get; set; }
        public string? Descricao { get; set; }
        public string? Rendimento { get; set; }
        public int? Codigo { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
