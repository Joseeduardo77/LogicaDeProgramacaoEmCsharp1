using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class PotenciasDe3
    {
        public static void Main(string[] args)
        {
            int baseNum = 3, expoente = 0;

            while (expoente <= 15)
            {
                double resultado = Math.Pow(baseNum, expoente);
                Console.WriteLine($"{baseNum}^{expoente} = {resultado}");
                expoente++;
            }
        }
    }
}
