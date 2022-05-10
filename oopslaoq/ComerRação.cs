using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ComerRação : IComer
    {
        public void Comer()
        {
            Console.WriteLine("Estou comendo ração");
        }
    }
}
