using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuario_Libros_Numero_RedSocial
{
    public class Libro
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }

        public Libro(int id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
        }
        public Libro()
        {

        }
        public string toString()
        {
            return $"ID: {id}, Titulo: {title}, Autor: {author}";
        }
    }
}
