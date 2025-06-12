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
        public void addNumber(int value)
        {
            root = addNumberRecursively(root, value);
        }
        public Numeros addNumberRecursively(Numeros numeros, int value)
        {
            if (numeros == null)
            {
                return new Numeros(value); 
            }
            if(numeros.value >= value)
            {
                numeros.lowernumber = addNumberRecursively(numeros.lowernumber, value);
            }
            if(numeros.value < value)
            {
                numeros.greaternumber = addNumberRecursively(numeros.greaternumber, value);
            }
            return numeros;
        }
        public void printNumbers()
        {
            printNumbersRecursively(root);
        }
        public void printNumbersRecursively(Numeros numeros)
        {
            if (numeros != null)
            {
                printNumbersRecursively(numeros.lowernumber);
                Console.WriteLine(numeros.value);
                printNumbersRecursively(numeros.greaternumber);
            }
        }
    }
}
