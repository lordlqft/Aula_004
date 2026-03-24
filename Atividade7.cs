using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

/*Ref. (15 pontos)
7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg.
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode
doar sangue ou não; caso não possa, diga o(s) motivo(s).

Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade7
    {
        public static void Executar()
        {
            int idade;
            double peso;

            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine()!);

            Console.Write("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine()!);

            if (idade >= 18 && peso >= 60)
            {
                if (idade > 67 || peso < 60)
                {
                    Console.WriteLine("Você não atende aos requisitos para prosseguir à doação de sangue.");
                }
                else
                {
                    Console.WriteLine("Você atende aos requisitos para prosseguir à doação de sangue!");
                }
            }
            else
            {
                Console.WriteLine("Você não atende aos requisitos para prosseguir à doação de sangue.");
            }
        }
    }
}