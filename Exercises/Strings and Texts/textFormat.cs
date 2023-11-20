using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findText
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name = "Fran Sabino";
            string text = "Welcome " + name + "! Merry Christmas";

            string textFormating = String.Format("Welcome {0} Merry Christmas {0} {1}", name, "Marry");

            Console.WriteLine(text);
            Console.WriteLine(textFormating);

            Console.ReadKey();

        }
    }
}
