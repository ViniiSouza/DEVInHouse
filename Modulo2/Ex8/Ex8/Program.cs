using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Vinícius\Documents\Programação\Projetos\DevInHouse\Exercicios\Modulo2\Ex8\Ex8\notas.json";
            var alunos = new List<Aluno>();
            using (StreamReader sr = File.OpenText(path))
            {
                var stringAlunos = sr.ReadToEnd();
                alunos = JsonSerializer.Deserialize<List<Aluno>>(stringAlunos);
            }
            if (alunos.Any(aluno => aluno.Nota > 5)) {
                Console.WriteLine("Alunos com nota acima de 5:");
                foreach (var aluno in alunos)
                {
                    if (aluno.Nota > 5)
                        Console.WriteLine(aluno.Nome);
                }
            }
            else
            {
                Console.WriteLine("Nenhum dos alunos teve nota acima de 5!");
            }
        }

        public class Aluno
        {
            public string Nome { get; set; }
            public float Nota { get; set; }
        }
    }
}
