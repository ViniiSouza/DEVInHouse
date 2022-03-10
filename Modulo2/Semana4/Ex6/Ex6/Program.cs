using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            var soma = Calculadora.Somar(1, 1, 5);
            var subtrair = Calculadora.Subtrair(15, 10, 5);
            var multiplicar = Calculadora.Multiplicar(3, 15, 7);
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtrair}");
            Console.WriteLine($"Multiplicação: {multiplicar}");
        }
    }
}
