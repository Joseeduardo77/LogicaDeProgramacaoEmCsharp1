using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
     class Tabuada
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
            }
        }
    }
}
