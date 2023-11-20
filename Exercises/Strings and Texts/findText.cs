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
            String texto = "Olá amigos, estou muito feliz de esta aqui com vocês. Desejo a todos um feliz ano";
            String palavra = "feliz"; //escolher uma variavel para localizar

            Console.WriteLine("Tamanho do texto: " + texto.Length); //lê o tamanho do conteudo contido na variavel "texto"
            Console.WriteLine("Localizar " + texto.IndexOf(palavra)); // localiza uma palavra (feliz) especifica dentro do texto
            Console.WriteLine("Localizar Ultimo: " + texto.LastIndexOf(palavra)); //localiza a ultima palavra (feliz) dentro do texto

            Console.ReadKey();

        }
    }
}
