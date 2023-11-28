using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
     class Veiculo2
    {

        //construtor padrão

        public Veiculo2()
        {
            Console.WriteLine("Construindo Veiculo");

        }

        public Veiculo2(int i)
        {
            Console.Write("Construindo Veiculo N: " + i);
        
        }

    public virtual void Andar() //metodo
        {
            Console.WriteLine("Veiculo Andando");
        }
    }
}
