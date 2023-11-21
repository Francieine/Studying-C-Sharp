using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Biblioteca; //executando programa de outro projeto

namespace ReferenciaPrograma
{
     class Program
    {
        static void Main(string[] args)
        {

            CalculoJuros calc = new CalculoJuros();
            double resultado = calc.Soma(10, 20);

            Console.WriteLine("Resultado da soma: " + resultado);
            Console.ReadKey();
        }
    }
}
