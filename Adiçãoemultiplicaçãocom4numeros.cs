using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class Adiçãoemultiplicaçãocom4numeros
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            int soma = A + B;
            int multiplicacao = C * D;

            Console.WriteLine($"Resultado da soma de A + B: {soma}");
            Console.WriteLine($"Resultado da multiplicação de C * D: {multiplicacao}");
        }
    }
}
