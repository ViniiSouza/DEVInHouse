using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Exame
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public int? IdConsulta { get; set; }

        public virtual Consulta? IdConsultaNavigation { get; set; }
    }
}
