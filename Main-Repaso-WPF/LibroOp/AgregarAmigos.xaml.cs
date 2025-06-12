using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Biblioteca_Usuario_Libros_Numero_RedSocial;

namespace Main_Repaso_WPF.LibroOp
{
   
    public partial class AgregarAmigos : Window
    {
        public List<string> Usuariosname = new List<string>();
        public List<UserRed> Usuarios { get; set; }
        public AgregarAmigos(List<UserRed> users)
        {
            InitializeComponent();
            Usuariosname = new List<string>();
            Usuarios= users;

            foreach (UserRed user in Usuarios)
            {
                if (user.usuario != null)
                {
                    string userName = user.usuario.name;
                    Usuariosname.Add(userName);
                }
                else
                {
                    // Handle the null case, e.g., log an error or skip the user  
                    Usuariosname.Add("Unknown User");
                }
            }
            nameusers.ItemsSource = Usuariosname;
            namefriend.ItemsSource = Usuariosname;
        }

        private void Haceramigos_Click(object sender, RoutedEventArgs e)
        {
            foreach (UserRed user in Usuarios)
            {
                if (user.usuario.name.Equals(nameusers.Text))
                {
                    foreach (UserRed friend in Usuarios)
                    {
                        if (friend.usuario.name.Equals(namefriend.Text))
                        {
                            user.AddFriends(friend);
                            MessageBox.Show("Amigo agregado correctamente: " + friend.usuario.name);
                        }
                    }

                }
            }
        }
    }
}
