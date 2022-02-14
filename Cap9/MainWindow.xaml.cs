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
using Cap9.Capitulo9;

namespace Cap9
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
         private void ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejer1 = new Ejercicio1();
            ejer1.Show();
        }

         private void ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ejer3 = new Ejercicio3();
            ejer3.Show();
        }

        private void ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejer4 = new Ejercicio4();
            ejer4.Show();
        }

        
    }
}
   