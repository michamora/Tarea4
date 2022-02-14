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
        Ejercicio 5 : Mostrar dos cadenas en orden alfabetico.
    */
    public partial class Ejercicio5 : Window
      {

        public string[] cadenas = new string[2];
        public int indice = 0;
        public Ejercicio5()
        {
            InitializeComponent();
        }
        private void agregar_Click(object sender, RoutedEventArgs e)
        {

            if (indice < 2)
            {
                cadenas[indice] = CadenasTextBox.Text;
                CadenasTextBox.Text = " ";
                indice = indice + 1;
            }
            else
            {
                MessageBox.Show("Limite de cadenas alcanzado");
            }

        }

        private void ordenar_Click(object sender, RoutedEventArgs e)
        {
                 
                IEnumerable<string> Orden = 
                from cadena in cadenas
                                            
                orderby cadena
                select cadena;             
                foreach (string s in Orden)

                {

                   imprimir.Items.Add(s);
                }
            

        }
    }
}