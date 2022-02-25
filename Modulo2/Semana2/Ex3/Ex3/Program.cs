using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float maiorNumero = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número");
                var numero = Console.ReadLine();
                if (float.Parse(numero) > maiorNumero)
                {
                    maiorNumero = float.Parse(numero);
                }
            }
            Console.WriteLine($"O maior número digitado foi: {maiorNumero}");
        }
    }
}
