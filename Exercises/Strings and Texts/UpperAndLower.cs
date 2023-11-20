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

            String text = "Hello my friends!";

            Console.WriteLine(text.ToUpper()); //method to change all text in Upper
            Console.WriteLine(text.ToLower()); //method to change all text in Lower


            Console.ReadKey();

        }
    }
}
