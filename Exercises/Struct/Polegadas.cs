using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Polegada
    {
        double centimetros;
        double polegada;

        public Polegada (double polegadas) //construtor
        {
            centimetros = 2.54;
            polegada = centimetros * polegadas;
        }

        public double GetPolegadaCentimetro()
        {
            return polegada;
        }


    }
}
