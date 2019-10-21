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
        
        ObservableCollection<string> Colores = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            Colores.Add("Rojo");
            Colores.Add("Azul");
            Colores.Add("Verde");
            Colores.Add("Amarillo");

            lstColores.ItemsSource = Colores;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Colores.Add(txtColor.Text);
            txtColor.Text = "";
        }

    }
}
