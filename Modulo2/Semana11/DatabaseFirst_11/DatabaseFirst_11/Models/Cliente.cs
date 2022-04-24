using System;
using System.Collections.Generic;

namespace DatabaseFirst_11.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? Status { get; set; }
        public int? IdContaCorrente { get; set; }

        public virtual ContaCorrente? IdContaCorrenteNavigation { get; set; }
    }
}
