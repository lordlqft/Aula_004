using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero.
Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade9
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine()!);

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
    }
}