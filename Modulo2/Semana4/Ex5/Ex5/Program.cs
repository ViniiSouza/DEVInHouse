using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            var p1 = new Pessoa();
            var p2 = new Pessoa("Vinícius", "de Souza", new DateTime(2002,10,25));

            Console.WriteLine("Pessoa 1:");
            Console.WriteLine($"Nome: {p1.Name} {p1.LastName}");
            Console.WriteLine($"Data de nascimento: {p1.BirthDate}");
            Console.WriteLine("Pessoa 2:");
            Console.WriteLine($"Nome: {p2.Name} {p2.LastName}");
            Console.WriteLine($"Data de nascimento: {p2.BirthDate}");

        }
    }
}
