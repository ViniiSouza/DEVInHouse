namespace Ex4
{
    public class SavingsAccount : Account
    {
        public decimal ReadyToWithdraw { get; set; }

        public SavingsAccount(decimal readyToWithdraw, string accountHash, int securityCode, int accountNumber, int accountDigit, string passwordEncrypted, decimal totalInvestments) : base(accountHash, securityCode, accountNumber, accountDigit, passwordEncrypted, totalInvestments)
        {
            ReadyToWithdraw = readyToWithdraw;
        }
    }
}
