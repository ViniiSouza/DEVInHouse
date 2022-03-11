using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class Seller : Employee
    {
        public int SoldItemsInTheMonth { get; set; }

        public decimal MaximumBudget { get; set; }

        public decimal MinimumGoal { get; set; }
    }
}
