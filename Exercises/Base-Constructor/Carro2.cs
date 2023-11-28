using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
     class Carro2 : Veiculo2
    {

        //construtor padrão

        public Carro2(int i) : base(i) // construtor com informações da classe base
        {
            Console.Write("Construindo Carro");
        }


        public override void Andar() // metodo sobreescrito
        {
            base.Andar(); //herda informações e comportamentos que estão dentro da classe base
            Console.WriteLine("Carro andando");
        }
    }
}
