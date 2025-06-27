using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    internal class PotenciaManual
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = 1, contador = 0;
            while (contador < expoente)
            {
                resultado *= baseNum;
                contador++;
            }

            Console.WriteLine($"{baseNum}^{expoente} = {resultado}");
        }
    }
}
