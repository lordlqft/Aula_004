using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Ref. (5 pontos)
10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.
Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade10
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}