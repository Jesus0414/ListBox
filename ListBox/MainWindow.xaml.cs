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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        ObservableCollection<Color> Colores = new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            /*Colores.Add("Rojo");
            Colores.Add("Azul");
            Colores.Add("Verde");
            Colores.Add("Amarillo");*/
            Colores.Add(new Color("Rojo", "#FF0000", "255, 0, 0"));
            Colores.Add(new Color("Verde", "#00FF00", "0, 255, 0"));
            Colores.Add(new Color("Azul", "#0000FF", "0, 0, 255"));


            lstColores.ItemsSource = Colores;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            /*Colores.Add(txtColor.Text);
            txtColor.Text = "";*/
            if (txtNombre.Text != "" && txtHexadecimal.Text != "" && txtRGB.Text != "")
            {
                Colores.Add(new Color(txtNombre.Text, txtHexadecimal.Text, txtRGB.Text));
                txtNombre.Clear();
                txtHexadecimal.Clear();
                txtRGB.Clear();
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
           if (lstColores.SelectedIndex != -1)
            {
                Colores.RemoveAt(lstColores.SelectedIndex);
            }
        }

        private void lstColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                txtNombreEditar.Text = Colores[lstColores.SelectedIndex].Nombre;
                txtHexadecimalEditar.Text = Colores[lstColores.SelectedIndex].Hexadecimal;
                txtRGBEditar.Text = Colores[lstColores.SelectedIndex].RGB;
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores[lstColores.SelectedIndex].Nombre = txtNombreEditar.Text;
                Colores[lstColores.SelectedIndex].Hexadecimal = txtHexadecimalEditar.Text;
                Colores[lstColores.SelectedIndex].RGB = txtRGBEditar.Text;
            }
            lstColores.Items.Refresh();
        }

    }
}
