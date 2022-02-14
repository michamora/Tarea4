using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cap9.Capitulo9
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*
       Ejercicio 4 : Enumeracion para los diferentes tipos de neumaticos
   
    */
    public partial class Ejercicio4 : Window
      {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        enum TipoNeumatico
        {
             Neumatico_Deportivo = 4,
               Neumatico_Radial = 8,
                 Neumatico_Diagonal = 12,
                    Neumatico_Pista = 16,
                       Neumatico_Tubeless = 24,
                         Neumatico_Runflat = 32,
          
        };
        private void Listar_Click(object sender, RoutedEventArgs e)
        {
           neumatico();
        }

        public void neumatico()
        {
            TipoNeumatico neumatico1 = TipoNeumatico.Neumatico_Deportivo;
            TipoNeumatico neumatico2 = TipoNeumatico.Neumatico_Radial;
            TipoNeumatico neumatico3 = TipoNeumatico.Neumatico_Diagonal;
            TipoNeumatico neumatico4 = TipoNeumatico.Neumatico_Pista;
            TipoNeumatico neumatico5 = TipoNeumatico.Neumatico_Tubeless;
            TipoNeumatico neumatico6 = TipoNeumatico.Neumatico_Runflat;
          
            pantalla.Items.Add(neumatico1);
            pantalla.Items.Add(neumatico2);
            pantalla.Items.Add(neumatico3);
            pantalla.Items.Add(neumatico4);
            pantalla.Items.Add(neumatico5);
            pantalla.Items.Add(neumatico6);
        }
    }

}