using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class Employee
    {
        public float Salary { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public ContractType ContractType { get; set; }

        public int HoursPerWeek { get; set; }

        public string Team { get; set; }
    }

    public enum ContractType
    {
        CLT = 0,
        PJ = 1
    }
}
