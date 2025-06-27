using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    internal class PotenciaGenerica
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a base (B): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente (E): ");
            int e = int.Parse(Console.ReadLine());

            long resultado = 1;

            for (int i = 1; i <= e; i++)
            {
                resultado = resultado * b;
            }

            Console.WriteLine("O resultado de " + b + " elevado a " + e + " e: " + resultado);
        }
    }
}
