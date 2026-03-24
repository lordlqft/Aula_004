using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número
de maçãs compradas, calcule e escreva o valor total da compra.
Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade5
    {
        public static void Executar()
        {
            int macas;
            Console.Write("Informe a quantidade de maçãs compradas: ");
            macas = int.Parse(Console.ReadLine()!);
            
            if (macas < 12)
            {
                double valor = macas * 0.30;
                Console.WriteLine($"{macas} Maçãs dão R$0,30 cada, sendo assim você pagará R${valor}!");
            }
            else if (macas >= 12 )
            {
                double valor = macas * 0.25;
                Console.WriteLine($"{macas} Maçãs dão R$0,25 cada, sendo assim você pagará R${valor}!");
            }
        }
    }
}