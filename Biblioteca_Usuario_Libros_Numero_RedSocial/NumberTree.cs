using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuario_Libros_Numero_RedSocial
{
    public class NumberTree
    {
        public Numeros root { get; set; }
        public Numeros current { get; set; }
        public NumberTree()
        {
            root = null;
            current = null;
        }

    }
}
