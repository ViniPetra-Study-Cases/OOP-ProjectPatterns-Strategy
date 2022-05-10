using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopslaoq
{
    abstract class Pato
    {
        protected IComer ComerBehaviour;
        protected IVoar VoarBehaviour;

        public void executaComer()
        {
            ComerBehaviour.Comer();
        }

        public void executavoar()
        {
            VoarBehaviour.Voar();
        }

        public string Name { get; private set; }

        protected Pato(string name)
        {
            Name = name;
        }

        public abstract void Falar();

        public virtual void Nadar()
        {
            Console.WriteLine($"O pato {this.Name} está nadando!");
        }
    }
}
