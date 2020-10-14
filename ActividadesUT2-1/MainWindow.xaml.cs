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

namespace ActividadesUT2_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rand = new Random();
        int nadiv = rand.Next(0,101); 

        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        private void Comprobar_Click(object sender, RoutedEventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            if(numero > nadiv)
            {
                txtResultado.Text = "¡Te has pasado!";
            }
            else if(numero < nadiv)
            {
                txtResultado.Text = "¡Te has quedado corto!";
            }
            else
            {
                txtResultado.Text = "¡Has acertado el numero a adivinar!";
            }
            
        }

        private void Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            nadiv = rand.Next(0, 101);
            txtResultado.Text = "";
        }
    }
}
