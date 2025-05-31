
using System.Security.Policy;

namespace Biblioteca_Usuario_Libros_Numero_RedSocial
{
    public class Usuario
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public Usuario(int id, string name, string lastName)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
        }
        public Usuario()
        {
            
        }

        public string toString()
        {
            return $"ID: {id}, Nombre: {name}, Apellido: {lastName}";
        }

}
