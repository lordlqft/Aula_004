using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Ref. (10 pontos)
8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime.
As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve, no final, emitir uma classificação sobre a participação da pessoa no
crime. Se a pessoa responder positivamente a 2 questões, ela deve ser
classificada/exibida como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino".
Caso contrário, ela será classificada como "Inocente".

Aluno: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade8
    {
        public static void Executar()
        {

            int quantidadeRespostas = 0;
            Console.Clear();
            Console.WriteLine("     Questionário Criminal\n-------------------------------\n");
            Console.WriteLine("Regras: Você deve responder as perguntas com apenas S/N");

            Console.Write("Pergunta 1: Você telefonou para a vítima?: ");
            string resposta1 = Console.ReadLine()!.ToLower();

            if (resposta1 == "s")
            {
                quantidadeRespostas++;
            }

            Console.Write("Pergunta 2: Você esteve no local do crime?: ");
            string resposta2 = Console.ReadLine()!.ToLower();

            if (resposta2 == "s")
            {
                quantidadeRespostas++;
            }

            Console.Write("Pergunta 3: Você mora perto da vítima?: ");
            string resposta3 = Console.ReadLine()!.ToLower();

            if (resposta3 == "s")
            {
                quantidadeRespostas++;
            }

            Console.Write("Pergunta 4: Você devia financeiramente para a vítima?: ");
            string resposta4 = Console.ReadLine()!.ToLower();

            if (resposta4 == "s")
            {
                quantidadeRespostas++;
            }

            Console.Write("Pergunta 5: Você já trabalhou com a vítima?: ");
            string resposta5 = Console.ReadLine()!.ToLower();

            if (resposta5 == "s")
            {
                quantidadeRespostas++;
            }

            if (quantidadeRespostas == 2)
            {
                Console.WriteLine("Classificação: Suspeita");
            }
            else if (quantidadeRespostas >= 3 && quantidadeRespostas <= 4)
            {
                Console.WriteLine("Classificação: Cúmplice");
            }
            else if (quantidadeRespostas == 5)
            {
                Console.WriteLine("Classificação: Assassino");
            }
            else
            {
                Console.WriteLine("Classificação: Inocente");
            }
        }
    }
}