using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Lib
{
    abstract class Veiculo // classe abstract fica disponivel somente para as classes derivadas/mesma pasta
    {
        abstract public String Marca { get; set; } //propriedades
        abstract public String Modelo { get; } //propriedades
        abstract public void MudarMarcha(byte NumeroMarcha); //metodo abstrata, sua implementação será obrigada em todos suas classes derivados
      
    }
}
