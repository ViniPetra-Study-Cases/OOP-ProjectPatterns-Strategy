using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopslaoq
{
    class PatoDeBorracha : Pato
    {
        public PatoDeBorracha(string name) : base(name)
        {
            this.ComerBehaviour = new ComerNãoComer();
            this.VoarBehaviour = new VoarNaoVoa();
        }
        public override void Nadar()
        {
            Console.WriteLine($"O pato {this.Name} está nadando");
        }

        public override void Falar()
        {
            Console.WriteLine($"Eu sou o pato {this.Name}");
        }
    }
}
