using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Ref. (10 pontos)
3 - Escreva um programa que receba três números inteiros e mostre eles em ordem
crescente.
Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade3
    {
        public static void Executar()
        {
            int numero1;
            int numero2;
            int numero3;

            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o terceiro número: ");
            numero3 = int.Parse(Console.ReadLine()!);

            double maior = 0;
            double medio = 0;
            double menor = 0;

            //Numero 1 maior que
            if (numero1 > numero2 || numero1 > numero3)
            {
                if (numero1 > numero2 && numero1 > numero3)
                {
                    maior = numero1;
                }
                else
                {
                    medio = numero1;
                }
            }
            else
            {
                menor = numero1;
            }

            //Numero 2 maior que
            if (numero2 > numero1 || numero2 > numero3)
            {
                if (numero2 > numero1 && numero2 > numero3)
                {
                    maior = numero2;
                }
                else
                {
                    medio = numero2;
                }
            }
            else
            {
                menor = numero2;
            }

            //Numero 3 maior que
            if (numero3 > numero1 || numero3 > numero2)
            {
                if (numero3 > numero1 && numero3 > numero2)
                {
                    maior = numero3;
                }
                else
                {
                    medio = numero3;
                }
            }
            else
            {
                menor = numero3;
            }

            Console.WriteLine($"{menor}, {medio}, {maior}");
        }
    }
}
