using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Vehicle veh = new Vehicle();
            Motocycle moto = new Motocycle();

            car.rodas = 4;
            moto.rodas = 2;

        }
    }
}
