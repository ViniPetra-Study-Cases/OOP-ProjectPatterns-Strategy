using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Marreco : Pato
    {
        public Marreco(string name) : base(name)
        {
            this.ComerBehaviour = new ComerRação();
            this.VoarBehaviour = new VoarAsa();
        }

        public override void Falar()
        {
            Console.WriteLine($"Eu sou o pato {this.Name}");
        }
    }
}
