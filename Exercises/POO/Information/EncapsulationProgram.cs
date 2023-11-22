using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.SetName(" Elias Costa");
            Console.Write(person1.GetName());

            Console.ReadKey();


        }
    }
}
