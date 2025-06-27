using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class GraosdeTrigo
    {
        public static void Main(string[] args)
        {
            
            double totalGraos = 0;
            double graosNaCasa = 1;

            
            for (int casa = 1; casa <= 64; casa++)
            {
                totalGraos = totalGraos + graosNaCasa;
                
                graosNaCasa = graosNaCasa * 2;
            }

            Console.WriteLine("O total de graos de trigo e: " + totalGraos);
        }
    }
}
