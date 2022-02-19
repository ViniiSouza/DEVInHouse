using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> listaNumeros = new List<float>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número:");
                var numero = Console.ReadLine();
                listaNumeros.Add(float.Parse(numero));
            }
            listaNumeros.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine($"Sequência decrescente: {string.Join(",", listaNumeros)}");
        }
    }
}
