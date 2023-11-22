using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAutoImplement  
{
    internal class Person
    {
       private string _name;
       public string Name { get { return Name; }  //customing autoimplemet proprieties
            set { Name = value.Trim().ToUpper(); 
            
            }

         }

    }
}
