using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\Users\Vinícius\Documents\Programação\Projetos\DevInHouse\Exercicios\Modulo2\Ex9\Ex9\notas.json";
            var pathToCreate = @"C:\Users\Vinícius\Documents\Programação\Projetos\DevInHouse\Exercicios\Modulo2\Ex9\Ex9\reprovados.json";

            var alunos = new List<Aluno>();
            var alunosReprovados = new List<Aluno>();
            using (StreamReader sr = File.OpenText(path))
            {
                var stringAlunos = sr.ReadToEnd();
                alunos = JsonSerializer.Deserialize<List<Aluno>>(stringAlunos);
            }
            if (alunos.Any(aluno => aluno.Nota < 5))
            {
                try
                {
                    foreach (var aluno in alunos)
                    {
                        if (aluno.Nota < 5)
                            alunosReprovados.Add(aluno);
                    }
                    using (StreamWriter sw = File.CreateText(pathToCreate))
                    {
                        var stringAlunosReprovados = JsonSerializer.Serialize(alunosReprovados);
                        sw.Write(stringAlunosReprovados);
                    }
                    Console.WriteLine("Os alunos reprovados foram salvos no arquivo com sucesso!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro na criação do arquivo: ");
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("Nenhum dos alunos foi reprovado!");
        }

        public class Aluno
        {
            public string Nome { get; set; }
            public float Nota { get; set; }
        }
    }
}
