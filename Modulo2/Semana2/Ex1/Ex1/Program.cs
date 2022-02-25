using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a área do círculo");
            var raio = Console.ReadLine();
            var raioConvertido = Convert.ToInt32(raio);
            var area = Math.PI * (raioConvertido * 2);
            Console.WriteLine($"O círculo tem uma área de {area}²");
        }
    }
}
