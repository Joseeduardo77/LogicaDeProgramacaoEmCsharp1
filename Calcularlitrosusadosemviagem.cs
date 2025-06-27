using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class Calcularlitrosusadosemviagem
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a velocidade média (km/h): ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo gasto na viagem (horas): ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            double distancia = velocidade * tempo;
            double litrosUsados = distancia / 12;

            Console.WriteLine($"Distância percorrida: {distancia} km");
            Console.WriteLine($"Litros usados: {litrosUsados} litros");
        }
    }
}
