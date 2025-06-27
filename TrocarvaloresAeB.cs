using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class TrocarvaloresAeB
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            string a = Console.ReadLine();

            Console.Write("Digite o valor de B: ");
            string b = Console.ReadLine();

            string temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Novo valor de A: {a}");
            Console.WriteLine($"Novo valor de B: {b}");
        }
    }
}
