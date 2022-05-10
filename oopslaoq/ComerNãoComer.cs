using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ComerNãoComer : IComer
    {
        public void Comer()
        {
            Console.WriteLine("Estou comendo Comida animada");
        }
    }
}
