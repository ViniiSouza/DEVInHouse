using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var soma = Calculadora.Somar(1, 1);
            var subtrair = Calculadora.Subtrair(15, 10);
            var multiplicar = Calculadora.Multiplicar(3, 15);
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtrair}");
            Console.WriteLine($"Multiplicação: {multiplicar}");
        }
    }
}
