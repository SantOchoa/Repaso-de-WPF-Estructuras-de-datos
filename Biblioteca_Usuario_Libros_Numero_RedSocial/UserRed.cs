using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuario_Libros_Numero_RedSocial
{
    public class UserRed
    {
        public Usuario usuario {  get; set; }
        public List<UserRed> Amigos { get; set; }

        public UserRed(Usuario usuario)
        {
            this.usuario = usuario;
            Amigos = new List<UserRed>();
        }
        public void AddFriends(UserRed amigo)
        {
            Amigos.Add(amigo);
        }
    }
}
