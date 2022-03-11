using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Account
    {
        public string AccountHash { get; set; }

        public int SecurityCode { get; set; }

        public int AccountNumber { get; set; }

        public int AccountDigit { get; set; }

        public int MyProperty { get; set; }

        public string PasswordEncrypted { get; set; }

        public decimal TotalInvestments { get; set; }
    }
}
