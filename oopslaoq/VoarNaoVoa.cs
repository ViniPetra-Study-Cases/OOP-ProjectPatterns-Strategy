﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopslaoq
{
    class VoarNaoVoa : IVoar
    {
        public void Voar()
        {
            Console.WriteLine("Não posso voar");
        }
    }
}
