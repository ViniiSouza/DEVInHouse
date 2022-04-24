using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Tratamento
    {
        public Tratamento()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int Id { get; set; }
        public int? IdAnimal { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public virtual Animal? IdAnimalNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
