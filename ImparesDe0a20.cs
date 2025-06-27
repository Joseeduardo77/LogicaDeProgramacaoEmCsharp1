using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class ImparesDe0a20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Numeros impares de 0 a 20:");

            for (int i = 0; i <= 20; i++)
            {
                // Se o resto da divisao por 2 for diferente de 0, o numero e impar
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
