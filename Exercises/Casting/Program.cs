using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/* Para realizar o casting coloca-se entre () o tipo que se deseja converter e logo apos o nome da variavel inicial (preco), o novo valor será atribuido a nova variavel (a) */
namespace Abstract
{
     class Program
    {
        static void Main(string[] args)
        {
            double preco = 3125.04;
            int a = (int)preco; // casting do tipo double para o tipo int, o valor convertido será atribuido a variavel "a"
        
        }
        }
}
