using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation  // autoimplement propriety its concise way to use proprieties' classes
{
    internal class Person
    {
        public int ID { get; set; } // the proprieties make private field automatic for using in the get and set, dont needed build code for proprieties
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(int id)
        {
            ID = id;
        }

        public override string ToString()
        {
            return ID + "\t" + Name + "\t" + Email;        
        }        

    }
}
