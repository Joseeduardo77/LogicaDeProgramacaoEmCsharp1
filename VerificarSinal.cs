using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    internal class VerificarSinal
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("Número positivo.");
            else if (numero < 0)
                Console.WriteLine("Número negativo.");
            else
                Console.WriteLine("Número igual a zero.");
        }
    }
}
