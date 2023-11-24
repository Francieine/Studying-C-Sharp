using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
     class Pessoa
    {
      
        void GetOlho()
        {
            Olho olho = new Olho();
        }

        public class Olho
        {
            public static string Iris = "XYZ";
            public Olho()
            {
                Pessoa pessoa = new Pessoa();
            }
        }

    }
}
