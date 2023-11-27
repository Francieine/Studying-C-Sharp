using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Lib
{
    class Carro : Veiculo
    {
        public override string Marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //implementação set e get herdada da classe veiculo

        public override string Modelo => throw new NotImplementedException(); //implementação get herdada da classe veiculo

        public override void MudarMarcha(byte NumeroMarcha)
        {
            throw new NotImplementedException(); //cada classe terá sua implementação de metodo, caso as outras classes tenham ações diferentes
        }
    }
}
