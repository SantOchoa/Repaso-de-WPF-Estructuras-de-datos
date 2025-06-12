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

namespace Main_Repaso_WPF
{
    /// <summary>
    /// Lógica de interacción para MostrarAmigos.xaml
    /// </summary>
    public partial class MostrarAmigos : Window
    {
        public List<string> Usuariosname = new List<string>();
        public List<UserRed> Usuarios { get; set; }
        public List<Usuario> amigos = new List<Usuario>();
        public MostrarAmigos(List<UserRed> userReds)
        {
            InitializeComponent();

            Usuariosname = new List<string>();
            Usuarios = userReds;

            numami.Text = userReds.First().Amigos.Count.ToString();

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
            
            
        }

        private void nameusers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            amigos.Clear();
                foreach (UserRed user in Usuarios)
                {
                    if (user.usuario.name == nameusers.SelectedItem as string)
                    {
                        
                        foreach (UserRed friend in user.Amigos)
                        {
                            if (friend.usuario != null)
                                amigos.Add(friend.usuario);
                           
                        }

                    }
                }


           

            /*string selectedName = nameusers.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedName))
            {
                foreach (UserRed user in Usuarios)
                {
                    if (user.usuario != null && user.usuario.name == selectedName)
                    {
                        foreach (UserRed friend in user.Amigos)
                        {
                            if (friend.usuario != null)
                            {
                                amigos.Add(friend.usuario);
                            }
                        }
                        break;
                    }
                }
            }*/
            amigostabla.ItemsSource = amigos;

        }
    }
}
