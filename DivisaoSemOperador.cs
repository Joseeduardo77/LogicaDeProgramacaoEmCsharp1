using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
     class DivisaoSemOperador
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());

            Console.Write("Digite o divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Erro! Nao pode dividir por zero.");
            }
            else
            {
                int quociente = 0;

                // Pega o valor sem o sinal para fazer a conta
                int dividendoTemp = Math.Abs(dividendo);
                int divisorTemp = Math.Abs(divisor);

                while (dividendoTemp >= divisorTemp)
                {
                    dividendoTemp = dividendoTemp - divisorTemp;
                    quociente = quociente + 1;
                }

                // Acerta o sinal do resultado no final
                if ((dividendo < 0 && divisor > 0) || (dividendo > 0 && divisor < 0))
                {
                    quociente = -quociente;
                }

                Console.WriteLine("O resultado da divisao e: " + quociente);
            }
        }
    }
}
