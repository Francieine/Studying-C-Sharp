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

            Polegada polegada = new Polegada(10);
            Console.WriteLine(polegada.GetPolegadaCentimetro());
            Console.ReadKey();
        }
    }
}
