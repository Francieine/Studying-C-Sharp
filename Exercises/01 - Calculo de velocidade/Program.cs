using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularVelocidadePermitida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();
            v.distancia = 850.5;
            v.tempo = 24.5;
            v.mensagem();
        }
    }
}

