using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
     class Exemple1Exceptions
    {
        private string Nome;
        private string CPF;
        private string CEP;

        public void SetCEP(string cep)
        {
            int resultado;
            int.Parse(cep);

            if(int.TryParse(cep, out resultado))
            {
                CEP = cep;
            }
            else
            {
                throw new Exception("CEP Invalido!");
            }
        }


    }
}
