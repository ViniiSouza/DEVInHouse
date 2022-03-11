using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class Manager : Employee
    {
        public List<string> ManagedTeams { get; set; }
    }
}
