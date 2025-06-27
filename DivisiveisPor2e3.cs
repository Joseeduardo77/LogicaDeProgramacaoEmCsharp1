using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class DivisiveisPor2e3
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
