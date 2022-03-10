using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class ClasseTeste2 : ClasseTeste
    {
        public void Metodo1()
        {
            var classe = new ClasseTeste2();
            classe.Nome = "Nome";
            classe.Data = DateTime.Now;
            classe.Descricao = "Descrição";
            classe.Id = 1;
        }
    }
}
