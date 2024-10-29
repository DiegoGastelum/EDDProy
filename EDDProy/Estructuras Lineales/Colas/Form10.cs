using System;
using System.Windows.Forms;

namespace EDDEMO
{
    public partial class Form10 : Form
    {
        // Nodo que representa cada elemento de la cola
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

        private Nodo frente; // Nodo al frente de la cola (cabeza)
        private Nodo final;  // Nodo al final de la cola

        public Form10()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            frente = null; // Inicializa la cola como vacía
            final = null;  // Inicializa el final de la cola como vacío
        }

        // Método para encolar un valor
        private void Enqueue(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato); // Crea un nuevo nodo
            if (final == null) // Si la cola está vacía
            {
                frente = nuevoNodo; // El nuevo nodo es el frente
                final = nuevoNodo;  // El nuevo nodo es el final
            }
            else
            {
                final.Siguiente = nuevoNodo; // El nodo actual al final apunta al nuevo nodo
                final = nuevoNodo; // Actualiza el final
            }
        }

        // Método para desencolar el valor al frente
        private int? Dequeue()
        {
            if (frente == null) // Si la cola está vacía
            {
                return null; 
            }

            int valor = frente.Dato; // Obtiene el valor del nodo al frente
            frente = frente.Siguiente; // Mueve el frente al siguiente nodo

            if (frente == null) // Si ahora la cola está vacía
            {
                final = null; 
            }

            return valor; 
        }

        // Método para vaciar la cola
        private void Vaciar()
        {
            frente = null; // Establece el frente como nulo
            final = null;  // También establece el final como nulo
            //Se establece como vacía
        }

        // Método para actualizar la caja de texto y mostrar los elementos 
        private void RefreshCola()
        {
            textBoxMostrarPila1.Clear(); // Limpia el TextBox que muestra la cola
            textBoxMostrarPila1.AppendText(MostrarElementos(frente)); // Agrega los elementos de la cola
        }

        // Método para mostrar los elementos 
        private string MostrarElementos(Nodo nodo)
        {
            if (nodo == null) // Si el nodo es nulo
            {
                return ""; 
            }
            // Retorna el dato del nodo actual y se llama recursivamente a sí mismo con el siguiente nodo
            return nodo.Dato + Environment.NewLine + MostrarElementos(nodo.Siguiente);
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar1_Click(object sender, EventArgs e)
        {
            string valor = textBoxInsertar1.Text;

            if (int.TryParse(valor, out int numero))
            {
                Enqueue(numero); // Inserta el número en la cola
                RefreshCola(); // Actualiza el TextBox para mostrar los elementos actuales de la cola
            }
            else
            {
                MessageBox.Show("Ingrese un número válido."); 
            }

            textBoxInsertar1.Clear(); // Limpia el TextBox de entrada
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            // Elimina el valor al frente de la cola
            int? eliminado = Dequeue();
            if (eliminado == null)
            {
                MessageBox.Show("La cola está vacía."); // Mensaje si está vacía
            }
            else
            {
                MessageBox.Show($"Elemento eliminado: {eliminado}");
            }
            RefreshCola(); // Actualiza el TextBox con los elementos restantes
        }

        private void btnVaciar1_Click(object sender, EventArgs e)
        {
            // Vacía la cola por completo
            Vaciar();
            RefreshCola(); // Actualiza el TextBox
            MessageBox.Show("La cola ha sido vaciada."); 
        }

        private void textBoxInsertar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMostrarPila1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
