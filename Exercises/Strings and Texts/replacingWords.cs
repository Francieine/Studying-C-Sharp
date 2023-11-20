using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replacingWords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String text = "Hello João friend's!";
            Console.WriteLine(text);

            String replaceText = text.Replace("João", "Fran"); // select the text variable and use method .Replace to replacing the name "joao" to "fran"
            Console.WriteLine(replaceText);
            Console.WriteLine(text);


            Console.ReadKey();

        }
    }
}
