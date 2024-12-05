using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        public frmPilas()
        {
            InitializeComponent();
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {

        }
        private class Nodo
        {
            public int Dato { get; set; } // Valor del nodo
            public Nodo Siguiente { get; set; } // Referencia al siguiente nodo

            public Nodo(int dato)
            {
                Dato = dato; // Inicializa el valor del nodo
                Siguiente = null; // Inicializa el siguiente nodo como null
            }
        }

        private Nodo top; // Nodo superior

        // Método para insertar un valor
        private void Push(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato); // Crea un nuevo nodo
            nuevoNodo.Siguiente = top; // El nuevo nodo apunta al nodo actual en la parte superior
            top = nuevoNodo; // Actualiza la parte superior al nuevo nodo
        }

        // Método para eliminar el valor superior 
        private int? Pop()
        {
            if (top == null) // Si la pila está vacía
            {
                return null;
            }

            int valor = top.Dato; // Obtiene el valor del nodo superior
            top = top.Siguiente; // Actualiza la parte superior al siguiente nodo
            return valor;
        }

        // Método para vaciar la pila
        private void Vaciar()
        {
            top = null; 
        }

        // Método para actualizar la caja de texto y mostrar los elementos 
        private void RefreshPila()
        {
            textBoxMostrarPila.Clear(); // Limpia el TextBox 
            textBoxMostrarPila.AppendText(MostrarElementos(top)); // Agrega los elementos al TextBox
        }

        // Método para mostrar los elementos
        private string MostrarElementos(Nodo nodo)
        {
            if (nodo == null) // Si el nodo es nulo
            {
                return "";
            }
            // Retorna el dato del nodo actual y se llama a sí mismo con el siguiente nodo
            return nodo.Dato + Environment.NewLine + MostrarElementos(nodo.Siguiente);
        }

        private void textBoxMostrarPila_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInsertar_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            // Elimina el valor superior de la pila
            int? eliminado = Pop();
            if (eliminado == null)
            {
                MessageBox.Show("La pila está vacía.");
            }
            else
            {
                MessageBox.Show($"Elemento eliminado: {eliminado}"); // Muestra el valor eliminado
            }
            RefreshPila(); // Actualiza el TextBox con los elementos restantes
        }

        //Botón para insertar un valor
        private void bttnInsertar_Click(object sender, EventArgs e)
        {
            string valor = textBoxInsertar.Text;

            if (int.TryParse(valor, out int numero))
            {
                Push(numero); // Inserta el número en la pila
                RefreshPila(); // Actualiza el TextBox 
            }
            else
            {
                MessageBox.Show("Ingrese un número válido."); 
            }

            textBoxInsertar.Clear(); // Limpia el TextBox
        }

        private void bttnVaciar_Click(object sender, EventArgs e)
        {
            // Vacía la pila por completo
            Vaciar();
            RefreshPila(); // Actualiza el TextBox
            MessageBox.Show("La pila está vacia.");
        }
    }
}
