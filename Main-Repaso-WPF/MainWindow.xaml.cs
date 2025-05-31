using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Main_Repaso_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Usurios_Click(object sender, RoutedEventArgs e)
        {
            Usuario_Queue usuarioQueue = new Usuario_Queue();
            usuarioQueue.Show();
            this.Close(); 
        }

        private void Libors_Click(object sender, RoutedEventArgs e)
        {
            Libros_Stack librosStack = new Libros_Stack();
            librosStack.Show();
            this.Close();
        }

        private void Numeros_Click(object sender, RoutedEventArgs e)
        {
            Numeros_Arbol numerosArbol = new Numeros_Arbol();
            numerosArbol.Show();
            this.Close();
        }

        private void Red_Social_Click(object sender, RoutedEventArgs e)
        {
            RedSocial_Grafo redSocialGrafo = new RedSocial_Grafo();
            redSocialGrafo.Show();
            this.Close();
        }
    }
}