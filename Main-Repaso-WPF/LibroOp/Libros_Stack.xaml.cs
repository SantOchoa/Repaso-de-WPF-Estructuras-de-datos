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
    /// Lógica de interacción para Libros_Stack.xaml
    /// </summary>
    public partial class Libros_Stack : Window
    {
        public static Stack<Libro> libros = new Stack<Libro>();
        public Libros_Stack()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarLibro agregarLibro = new AgregarLibro();
            agregarLibro.ShowDialog();
            libros.Push(agregarLibro.LibroCreado);
           
        }

        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            Window1 ventana = new Window1(libros.Peek());
            ventana.Show();


        }
    }
}
