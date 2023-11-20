using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serchingWordsintText
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String text = "Hello José Costa Ribeiro Martins friends!";

            Console.WriteLine("search for word exist in text initial: " + text.StartsWith("Hello")); //will find the inicial word in text

            Console.WriteLine("search for word exist in text final: " + text.EndsWith("!")); //will find the final word in text


            Console.WriteLine("search for word exist in all text : " + text.StartsWith("Costa")); //will find the especific word in text



            Console.ReadKey();

        }
    }
}
