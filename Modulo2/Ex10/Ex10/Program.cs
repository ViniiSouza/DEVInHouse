using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário do funcionário: ");
            var salario = Console.ReadLine();
            var salarioConvertido = float.Parse(salario);
            var percentualAumento = 0;
            float valorAumento = 0;
            float salarioFinal = 0;

            switch (salarioConvertido)
            {
                case <= 280:
                    percentualAumento = 20;
                    valorAumento = salarioConvertido * ((float)percentualAumento / 100);
                    salarioFinal = salarioConvertido + valorAumento;
                    break;
                case > 280 and < 700:
                    percentualAumento = 15;
                    valorAumento = salarioConvertido * ((float)percentualAumento / 100);
                    salarioFinal = salarioConvertido + valorAumento;
                    break;
                case > 700 and < 1500:
                    percentualAumento = 10;
                    valorAumento = salarioConvertido * ((float)percentualAumento / 100);
                    salarioFinal = salarioConvertido + valorAumento;
                    break;
                case > 1500:
                    percentualAumento = 5;
                    valorAumento = salarioConvertido * ((float)percentualAumento / 100);
                    salarioFinal = salarioConvertido + valorAumento;
                    break;
                default:
                    break;
            }

            Console.Write($"Salário antes do reajuste: R$ {salarioConvertido}\nPercentual de aumnento aplicado: {percentualAumento}%\nValor do aumento: R$ {valorAumento}\nNovo salário com aumento aplicado: R$ {salarioFinal}");
        }
    }
}
