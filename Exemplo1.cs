using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace Aula_004
{
    public static class Exemplo1
    {
        public static void Executar()
        {
            double nota;
            double frequencia;

            Console.Write("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a frequência do aluno: %");
            frequencia = double.Parse(Console.ReadLine()!);

            if (nota >= 7)
            {
                if (frequencia >= 75)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado por falta!");
                }
            }
            else
            {
                Console.WriteLine("Aluno reprovado por nota!");
            }
        }
    }
}