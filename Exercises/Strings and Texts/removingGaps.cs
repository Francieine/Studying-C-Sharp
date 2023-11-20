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

            String text = "           Hello Fran's friends!                            ";
            Console.WriteLine("Initial Gap Removed: " + text.TrimStart());
            Console.WriteLine("Gap's Removed Length :" + text.TrimStart().Length);

            Console.WriteLine("Final Gap Removed: " + text.TrimEnd());
            Console.WriteLine("Gap's Removed Length :" + text.TrimEnd().Length);

            Console.WriteLine("All Gap Removed: " + text.Trim());
            Console.WriteLine("All Gap's Removed Length :" + text.Trim().Length);

            Console.ReadKey();

        }
    }
}
