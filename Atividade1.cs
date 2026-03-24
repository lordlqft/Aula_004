using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

/*Ref (5 pontos)
1 - Faça um programa que calcule e apresente o valor do volume de uma lata,
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores
de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO2 * ALTURA.
Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade1
    {
        public static void Executar()
        {
            double PI = 3.14159;
            double raio;
            double altura;
            double volume;

            Console.Write("Digite o valor do raio da lata: ");
            raio = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o valor da altura da lata: ");
            altura = double.Parse(Console.ReadLine()!);

            volume = PI * (raio * raio) * altura;
            Console.WriteLine($"O volume da lata é: {volume}");
        }
    }
}