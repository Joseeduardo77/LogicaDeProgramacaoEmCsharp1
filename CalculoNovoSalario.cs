using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class CalculoNovoSalario
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o salário mensal atual: ");
            double salarioMensal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de reajuste (%): ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            double novoSalario = salarioMensal + (salarioMensal * percentual / 100);

            Console.WriteLine($"Novo salário com reajuste: R$ {novoSalario:F2}");
        }
    }
}
