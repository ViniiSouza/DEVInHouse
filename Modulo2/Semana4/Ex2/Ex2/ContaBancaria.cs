namespace Ex2
{
    public class ContaBancaria
    {
        public int ContaNumero { get; private set; }

        public int ContaDigito { get; private set; }

        public string NomeTitular { get; private set; }

        public string Agencia { get; private set; }

        public string Endereco { get; private set; }

        public decimal Saldo { get; private set; }

        public ContaBancaria(int contaNumero, int contaDigito, string nomeTitular, string agencia, string endereco, decimal saldo)
        {
            ContaNumero = contaNumero;
            ContaDigito = contaDigito;
            NomeTitular = nomeTitular;
            Agencia = agencia;
            Endereco = endereco;
            Saldo = saldo;
        }
    }
}
