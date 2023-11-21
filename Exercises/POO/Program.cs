using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Information person1 = new Information();

            person1.setDates(2023, 1991);

            Console.Write("Age: " + person1.CalcAge());

            Console.ReadKey();

        }
    }
}
