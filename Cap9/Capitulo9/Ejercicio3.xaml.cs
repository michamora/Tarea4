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
       Ejercicio 3 : Estructuras enlazadas para guardar la informacion de una amscota y su dueño.
    */
    public partial class Ejercicio3 : Window
      {
        
        private List<Persona> Lista;
        public struct Mascota
        {
            public string raza;
            public string nombre;
            public Mascota(string Raza, string Nombre)
            {
                raza= Raza;
                nombre = Nombre;
            }
        }
        public struct Persona
        {
            public int edad;
            public string nombre;
            public Mascota mascota;
            public Persona(int Edad, string Nombre, Mascota mascota)
            {
                edad = Edad;
                nombre = Nombre;
                this.mascota = mascota;
            }
        }
        public Ejercicio3() 
        {
            Lista = new List<Persona>();
            InitializeComponent();
        }
        private void Guardar_Click(object sander, RoutedEventArgs e)
        {
            Persona nueva = new Persona(int.Parse(EdadTextBox.Text),NombreTextBox.Text, new Mascota(RazaTextBox.Text, Nombre2TextBox.Text));
            Lista.Add(nueva);
            MessageBox.Show($"La persona: {nueva.nombre} se ha guardado correctamente junto a su mascota {nueva.mascota.nombre}.","Aviso!");
        }
         private void Listar_Click(object sender, RoutedEventArgs e)
        {
            Persona nueva = new Persona(int.Parse(EdadTextBox.Text),NombreTextBox.Text, new Mascota(RazaTextBox.Text, Nombre2TextBox.Text));
            Lista.Add(nueva);

        MessageBox.Show($"Dueño: {nueva.nombre} | Mascota {nueva.mascota.nombre}.","Consulta");
      
        }
    }
}