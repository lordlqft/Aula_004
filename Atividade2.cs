using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Ref (5 pontos)
2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.

Atividades – Operadores Aritméticos, Operadores Lógicos e Condicionais 1

Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade2
    {
        public static void Executar()
        {
            string letra;

            Console.Write("Digite uma letra para ser verificada: ");
            letra = Console.ReadLine()!.ToLower();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine($"A letra \"{letra}\" é uma vogal.");
            }
            else
            {
                Console.WriteLine($"A letra \"{letra}\" é uma consoante.");
            }
        }
    }
}