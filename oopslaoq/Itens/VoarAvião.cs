using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class VoarAvião : IVoar
    {
        public void Voar()
        {
            Console.WriteLine("Voando de avião");
        }
    }
}
