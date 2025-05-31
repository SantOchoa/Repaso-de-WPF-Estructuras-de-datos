using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuario_Libros_Numero_RedSocial
{
    public class Numeros
    {
        public int value { get; set; }
        public Numeros greaternumber { get; set; }
        public Numeros lowernumber { get; set; }
        public Numeros(int value)
        {
            this.value = value;
            this.greaternumber = null;
            this.lowernumber = null;
        }
        public Numeros()
        {
            this.value = 0;
            this.greaternumber = null;
            this.lowernumber = null;
        }

    }
}
