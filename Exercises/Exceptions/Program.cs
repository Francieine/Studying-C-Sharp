using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/*Exceptions são erros esperados e que podem ser tratados. 
 Usamos "try" para possibilidade do erro e "catch" para tratramento do erro*/

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // usa o try quando se sabe que poderá haver erro
            {
                Exemple1Exceptions excp = new Exemple1Exceptions();
                excp.SetCEP("ASD"); // codigo que pode gerar erro
            }
            catch (FormatException forExc) //caso haja erro o catch irá tratar o erro
            {
                Console.WriteLine("Erro format: " + forExc.Message);
            }
            catch (Exception excp)
            {
                Console.WriteLine("Erro: " + excp.Message);
            }
            finally
            {

            }
            Console.ReadKey();
        }
        }
}
