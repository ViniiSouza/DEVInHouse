namespace Ex4
{
    public class CheckingAccount : Account
    {
        public decimal Balance { get; set; }

        public CheckingAccount(decimal balance, string accountHash, int securityCode, int accountNumber, int accountDigit, string passwordEncrypted, decimal totalInvestments) : base(accountHash, securityCode, accountNumber, accountDigit, passwordEncrypted, totalInvestments)
        {
            Balance = balance;
        }
    }
}
