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
    /// Lógica de interacción para AgregarLibro.xaml
    /// </summary>
    public partial class AgregarLibro : Window  
    {
        public AgregarLibro()
        {
            InitializeComponent();
        }
        public Libro LibroCreado { get; private set; }

        public void guardar_Click_1(object sender, RoutedEventArgs e)
        {
            int idm = int.Parse(id.Text);
            string titlem = name.Text;
            string authorm = author.Text;

            LibroCreado = new Libro(idm, titlem, authorm);
            this.DialogResult = true;
            this.Close();
        }
    }
}
