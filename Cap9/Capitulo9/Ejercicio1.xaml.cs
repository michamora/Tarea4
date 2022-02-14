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

namespace Cap9.Capitulo9
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*
        Ejercicio 1 : Estructura para guardar los productos de una tienda.
    */
   struct Productos
    {
        public int Productoid { get; set; }   
        public string Nombre  { get; set; }
        public int Costo { get; set; }
        public int Existencia { get; set; }


       public Productos(int productoid , string nombre , int costo , int existencia ){

         this.Productoid = productoid;
              this.Nombre = nombre;
                  this.Costo = costo;
                       this.Existencia = existencia;
       }
        public override string ToString()
            {
                StringBuilder imprimir = new StringBuilder();
                imprimir.AppendFormat($" Producto ID : { Productoid}\n Nombre : {Nombre}\n Cantidad : {Existencia}\n Precio : {Costo}");

                return imprimir.ToString();
         }
    }
        public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {         
            Productos producto = new Productos(int.Parse(ProductoIdTextBox.Text),NombreTextBox.Text,int.Parse(CostoTextBox.Text), int.Parse(ExistenciaTextBox.Text));
            MessageBox.Show("Producto guardado con exito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {

           Productos producto = new Productos(int.Parse(ProductoIdTextBox.Text),NombreTextBox.Text,int.Parse(CostoTextBox.Text), int.Parse(ExistenciaTextBox.Text));
           pantalla.Items.Add(producto);
      
        }
    }
}