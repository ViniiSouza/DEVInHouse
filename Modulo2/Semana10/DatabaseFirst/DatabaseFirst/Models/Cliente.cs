using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public double? Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Telefone { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
