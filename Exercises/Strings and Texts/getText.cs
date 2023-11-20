using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getText
{
    internal class Program
    {
        static void Main(string[] args)
        {


            String text = "Hello Everybody! I wish happy new year for us!";
            String quote = text.Substring(6); //select 6º caracter to end final text
            String word = text.Substring(6, 10); //select just one word starts in 6 caracter and end in 10 caracter

            Console.WriteLine("2ª quote: " + quote);
            Console.WriteLine("Word: " + word);


            Console.ReadKey();

        }
    }
}
