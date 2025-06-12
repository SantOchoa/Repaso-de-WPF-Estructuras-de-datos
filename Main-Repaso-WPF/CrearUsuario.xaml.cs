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
    /// Lógica de interacción para CrearUsuario.xaml
    /// </summary>
    public partial class CrearUsuario : Window
    {
        public Usuario usuario { get; set; }
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void createUser_Click(object sender, RoutedEventArgs e)
        {
            string nameu = name.Text;
            string lastNameu = lastname.Text;
            int idu = int.Parse(id.Text);

            usuario = new Usuario(idu, nameu, lastNameu);
            this.DialogResult = true;
            this.Close(); 

        }

        private void lastname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
