using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation  // encapsulation is the protect way main datas using access modifieds, getters and setters
{
    internal class Person
    {
        private string Name;
        string CEP;
        string adress;
        string CPF;

        public void SetName(String name) //input datas
        {
            Name = name; 
        }

        public string GetName() //output datas
        {
            return Name;
        }

    }
}
