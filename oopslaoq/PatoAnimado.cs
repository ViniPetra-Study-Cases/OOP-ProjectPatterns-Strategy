using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopslaoq
{
    class PatoAnimado : Pato
    {
        public PatoAnimado(string name) : base(name)
        {
            this.ComerBehaviour = new ComerComidaAnimada();
            this.VoarBehaviour = new VoarAvião();
        }

        public override void Falar()
        {
            Console.WriteLine($"Eu sou o pato {this.Name}");
        }
    }
}
