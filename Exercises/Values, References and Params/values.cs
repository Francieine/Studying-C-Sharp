using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;

            Console.WriteLine("Main valor: " + valor);  

            AlterarValor(valor); //passagem por valor
                Console.WriteLine("Main valor " + valor);
           

            Console.ReadKey();
        }

        static void AlterarValor(double valor)
        {
            Console.WriteLine("AlterarValor" + valor);
        }
    }
}
