using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
     class This
    {
        string Marca;
        string Modelo;
        string AnoFabricacao;
        string AnoModelo;


        public void SetMarca(String Marca)
        {
            this.Marca = Marca; // a palavra this está referenciando ao Modelo como propriedade/atributo do objeto e não ao que está no parametro
        }

        public void SetModelo(String Modelo)
        {
            this.Modelo = Modelo;
        }

    }
}
