using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class ParOuImpar
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Número par.");
            else
                Console.WriteLine("Número ímpar.");
        }
    }
}
