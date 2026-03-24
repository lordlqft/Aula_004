using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado.
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°,
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°,
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo.
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome: Kenneth Anderson Pedrosa Cavalcante
*/

namespace Aula_004
{
    public static class Atividade6
    {
        public static void Executar()
        {
            Console.Write("Digite o primeiro ângulo: ");
            double angulo1 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o segundo ângulo: ");
            double angulo2 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o terceiro ângulo: ");
            double angulo3 = double.Parse(Console.ReadLine()!);

            double Sa = angulo1 + angulo2 + angulo3;

            if (Sa != 180)
            {
                Console.WriteLine("Não é um triângulo.");
            }
            else if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
            {
                Console.WriteLine("O triângulo é retângulo");
            }
            else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
            {
                Console.WriteLine("O triângulo é obtusângulo");
            }
            else if (angulo1 < 90 || angulo2 < 90 || angulo3 < 90)
            {
                Console.WriteLine("O triângulo é acutângulo");
            }
        }
    }
}
