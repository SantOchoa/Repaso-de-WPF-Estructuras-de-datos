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
using Main_Repaso_WPF.LibroOp;

namespace Main_Repaso_WPF
{
    /// <summary>
    /// Lógica de interacción para RedSocial_Grafo.xaml
    /// </summary>
    public partial class RedSocial_Grafo : Window
    {
        public  List<UserRed> usuarios = new List<UserRed>();
        public RedSocial_Grafo()
        {
            InitializeComponent();
        }

        private void Usuario_Click(object sender, RoutedEventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.ShowDialog();
            if (crearUsuario.usuario != null)
            {
                usuarios.Add(new UserRed(crearUsuario.usuario));
            }
            else
            {
                MessageBox.Show("No se creó un usuario válido.");
            }
            
        }

        private void Amigos_Click(object sender, RoutedEventArgs e)
        {
            AgregarAmigos agregarAmigos = new AgregarAmigos(usuarios);
            agregarAmigos.ShowDialog();
            usuarios = agregarAmigos.Usuarios;
        }

        private void mostrar_Click(object sender, RoutedEventArgs e)
        {
            MostrarAmigos mostrarAmigos = new MostrarAmigos(usuarios);
            mostrarAmigos.ShowDialog();

        }
    }
}
