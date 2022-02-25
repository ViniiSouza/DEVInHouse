using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em celsius:");
            var temperatura = Console.ReadLine();
            var temperaturaParseada = float.Parse(temperatura.Replace(".",","));
            var temperaturaConvertida = temperaturaParseada * 33.8;
            Console.WriteLine($"{temperaturaParseada}° celsius equivalem a {Math.Round(temperaturaConvertida, 2)}° fahrenheit");
        }
    }
}
