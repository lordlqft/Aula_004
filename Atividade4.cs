using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente,
tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente
(A, B, C, D ou E), conforme a seguinte tabela:
A - nota >= 8,5 e nota <= 10
B - nota >= 7 e nota < 8,5
C - nota >= 5 e nota < 7
D - nota >= 3 e nota < 5
E - nota < 3
Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade4
    {
        public static void Executar()
        {
            double n1;
            double n2;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine()!);

            double media = (n1 + n2) / 2;

            double nota = media;
            if (nota >= 8.5 && nota <= 10)
            {
                Console.WriteLine($"A média do aluno é nota A ({media})");

            }
            else if (nota >= 7 && nota < 8.5)
            {
                Console.WriteLine($"A média do aluno é nota B ({media})");
            }
            else if (nota >= 5 && nota < 7)
            {
                Console.WriteLine($"A média do aluno é nota C ({media})");
            }
            else if (nota >= 3 && nota < 5)
            {
                Console.WriteLine($"A média do aluno é nota D ({media})");
            }
            else if (nota > 3)
            {
                Console.WriteLine($"A média do aluno é nota E ({media})");
            }
            
        }
    }
}