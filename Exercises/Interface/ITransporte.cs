using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Lib
{
    internal interface ITransporte //interface é um contrato de implementações, obrigando as classes realizarem a consntrução de seus metodos e propriedades
    {
        void Mover(byte velocidade);
    }
}
