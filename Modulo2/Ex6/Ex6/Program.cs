using System;
using System.Collections.Generic;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> lados = new List<float>();
            
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Digite o {i}° lado do triângulo");
                var lado = Console.ReadLine();
                lados.Add(float.Parse(lado));
            }
            var lado1 = lados[0];
            var lado2 = lados[1];
            var lado3 = lados[2];
            if (lado1 + lado2 < lado3 || lado1 + lado3 < lado2 || lado2 + lado3 < lado1)
            {
                Console.WriteLine("Triângulo inválido!");
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("O triângulo é equilátero!");
            }
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {
                Console.WriteLine("O triângulo é escaleno!");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("O triângulo é Isósceles!");
            }
        }
    }
}
