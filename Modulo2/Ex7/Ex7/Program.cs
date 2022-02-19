using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            var numero = Console.ReadLine();
            var numeroConvertido = int.Parse(numero);
            var resultado = 0;
            while (numeroConvertido > 0)
            {
                resultado = resultado * 10 + numeroConvertido % 10;
                numeroConvertido /= 10;
            }
            Console.WriteLine($"O número invertido é: {resultado}");
        }
    }
}
