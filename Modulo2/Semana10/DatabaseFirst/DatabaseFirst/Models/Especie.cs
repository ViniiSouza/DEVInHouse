using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Especie
    {
        public Especie()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public int? IdAnimal { get; set; }
        public string? Descricao { get; set; }

        public virtual Animal? IdAnimalNavigation { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
