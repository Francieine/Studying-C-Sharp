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

            Person person = new Person(1);
            person.Name = "Fran";
            person.Email = "fran@fran.com.br";

            Console.WriteLine(person);


            Console.ReadKey();


        }
    }
}
