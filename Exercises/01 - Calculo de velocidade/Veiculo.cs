using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularVelocidadePermitida
{
    internal class Veiculo
    {
        //atributos

        public double tempo, distancia;

        //metodo para calcular a velocidade (processamento de dados)
        public double calcularVelocidade()
        {
            return distancia / tempo;
        }

        //metodo para verificar a velocidade permitida no local

        public string VerificarVelPermitida(double velocidade)
        {
            //criar uma variavel para usar na verificacao de condicao

            string retorno;

            //condição

            if(velocidade < 20)
            {
                retorno = "Velocidade muito baixa";

            }else if(velocidade < 40)
            {
                retorno = "Velocidade para bairros";
            }
            else {
                retorno = "Velocidade para trafegos medianos";
            }

            return retorno;

        }

        //metodo para exibir uma mensagem

        public void mensagem()
        {
            //variavel criada para mostrar velocidade
            double obterCalculoVelocidade = calcularVelocidade();

            //variavel criada para mostrar situação de velocidade
            string obterVelocidadePermitida = VerificarVelPermitida(obterCalculoVelocidade);

            Console.WriteLine("A velocidade é de " + obterCalculoVelocidade);
            Console.WriteLine("Permissao: " + obterVelocidadePermitida);
        
        
        }

       

    }
}
