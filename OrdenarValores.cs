using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class OrdenarValores
    {
        public static void Main(string[] args)
        {
            int[] valores = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);

            Console.WriteLine("Valores em ordem crescente:");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
