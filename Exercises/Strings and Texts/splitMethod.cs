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

            String nomes = "Joao, Maria, Jose, Jesus, Filipe, Tiago e Paulo";
            String[] separador = { "," , "e" };

           String[] nomesArray = nomes.Split(separador, StringSplitOptions.None); //method split removing "," and "e".

            foreach(string nome in nomesArray) 
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();

        }
    }
}
