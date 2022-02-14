using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cap8.Capitulo8
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*
        Ejercicio 3 : Mostrar la fecha y hora actual.
    */
    public partial class Ejercicio3 : Window
      {
           public Ejercicio3()
        {            
            InitializeComponent(); 
        }    
        private void calcular_Click(object sender, RoutedEventArgs e)
        {

            FechaYHora.Text= string.Format("{0:dd}/{0:MM}/{0:yyyy}\n {0:hh}:{0:mm}",DateTime.Now);
        }
}
}