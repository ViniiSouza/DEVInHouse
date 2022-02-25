using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            float menorNumero = float.MaxValue;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Digite um número: ");
                var numero = Console.ReadLine();
                if (float.Parse(numero) < menorNumero)
                {
                    menorNumero = float.Parse(numero);
                }
            }
            Console.WriteLine($"O menor número digitado foi: {menorNumero}");
        }
    }
}
