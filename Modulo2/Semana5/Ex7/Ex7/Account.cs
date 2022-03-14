namespace Ex4
{
    public class Account
    {
        public string AccountHash { get; set; }

        public int SecurityCode { get; set; }

        public int AccountNumber { get; set; }

        public int AccountDigit { get; set; }

        public string PasswordEncrypted { get; set; }

        public decimal TotalInvestments { get; set; }

        public Account(string accountHash, int securityCode, int accountNumber, int accountDigit, string passwordEncrypted, decimal totalInvestments)
        {
            AccountHash = accountHash;
            SecurityCode = securityCode;
            AccountNumber = accountNumber;
            AccountDigit = accountDigit;
            PasswordEncrypted = passwordEncrypted;
            TotalInvestments = totalInvestments;
        }
    }
}
