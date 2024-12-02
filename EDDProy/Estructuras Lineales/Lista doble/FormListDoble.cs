using System;
using System.Text;
using System.Windows.Forms;

namespace EDDEMO
{
    public partial class FormListDoble : Form
    {
        public FormListDoble()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        // Clase que representa un nodo de la lista doble
        public class Nodo
        {
            public string Valor;
            public Nodo Siguiente;
            public Nodo Anterior;

            public Nodo(string valor)
            {
                Valor = valor;
                Siguiente = null;
                Anterior = null;
            }
        }

        // Clase que representa la lista 
        public class ListaDoble
        {
            private Nodo cabeza; // Cabeza de la lista
            private Nodo cola; // Cola de la lista
            private int tamaño; // Tamaño de la lista

            public ListaDoble()
            {
                cabeza = null; // Inicializa la cabeza
                cola = null; // Inicializa la cola
                tamaño = 0; // Tamaño inicial
            }

            // Método para agregar un nuevo elemento al final
            public void Agregar(string valor)
            {
                Nodo nuevoNodo = new Nodo(valor);
                if (cabeza == null)
                {
                    cabeza = nuevoNodo; // Si la lista está vacía, el nuevo nodo es la cabeza
                    cola = nuevoNodo; // El nuevo nodo es también la cola
                }
                else
                {
                    cola.Siguiente = nuevoNodo; // Conectar el último nodo con el nuevo
                    nuevoNodo.Anterior = cola; // Conectar el nuevo nodo con la cola actual
                    cola = nuevoNodo; // Actualizar la cola al nuevo nodo
                }
                tamaño++;
            }

            // Método para insertar un elemento en una posición 
            public void InsertarEnPosicion(string valor, int posicion)
            {
                // Verificar si la posición es válida
                if (posicion < 1 || posicion > tamaño + 1)
                {
                    MessageBox.Show("Posición inválida."); 
                    return;
                }

                Nodo nuevoNodo = new Nodo(valor); // Crear un nuevo nodo

                if (posicion == 1)
                {
                    // Insertar al principio
                    nuevoNodo.Siguiente = cabeza; // Conectar el nuevo nodo al nodo actual cabeza
                    if (cabeza != null)
                    {
                        cabeza.Anterior = nuevoNodo; // Conectar la cabeza anterior con el nuevo nodo
                    }
                    cabeza = nuevoNodo; // Actualizar la cabeza
                    if (cola == null) // Si la lista estaba vacía
                    {
                        cola = nuevoNodo; // Actualizar cola
                    }
                }
                else if (posicion == tamaño + 1)
                {
                    // Insertar al final
                    Agregar(valor); // Usa el método Agregar para añadir al final
                    return;
                }
                else
                {
                    // Insertar en medio
                    Nodo actual = cabeza;
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        actual = actual.Siguiente; // Mover al nodo en la posición deseada
                    }

                    nuevoNodo.Siguiente = actual; // Conectar el nuevo nodo con el siguiente
                    nuevoNodo.Anterior = actual.Anterior; // Conectar el nuevo nodo con el anterior

                    // Verifica que actual.Anterior no sea null
                    if (actual.Anterior != null)
                    {
                        actual.Anterior.Siguiente = nuevoNodo; // Conectar el anterior con el nuevo nodo
                    }
                    actual.Anterior = nuevoNodo; // Conectar el siguiente con el nuevo nodo
                }
                tamaño++; 
            }

            // Método para eliminar el último elemento 
            public void EliminarUltimo()
            {
                if (cola == null)
                {
                    MessageBox.Show("La lista está vacía."); 
                    return;
                }

                if (cola == cabeza)
                {
                    cabeza = null; // Si hay un solo nodo, vaciar la lista
                    cola = null;
                }
                else
                {
                    cola = cola.Anterior; // Mover la cola al nodo anterior
                    cola.Siguiente = null; // Desconectar el último nodo
                }
                tamaño--; 
            }

            // Método para eliminar el primer elemento 
            public void EliminarPrimero()
            {
                if (cabeza == null)
                {
                    MessageBox.Show("La lista está vacía."); 
                    return;
                }

                cabeza = cabeza.Siguiente; // Mover la cabeza al siguiente nodo
                if (cabeza != null)
                {
                    cabeza.Anterior = null; // Desconectar el nodo anterior
                }
                else
                {
                    cola = null; // Si la lista queda vacía, vaciar la cola
                }
                tamaño--; 
            }

            // Método para eliminar un elemento en cualquier posición
            public void EliminarEnPosicion(int posicion)
            {
                if (posicion < 1 || posicion > tamaño)
                {
                    MessageBox.Show("Posición inválida."); 
                    return;
                }

                if (posicion == 1)
                {
                    EliminarPrimero(); // Eliminar el primero si es la posición 1
                    return;
                }

                if (posicion == tamaño)
                {
                    EliminarUltimo(); // Eliminar el último si es la última posición
                    return;
                }

                Nodo actual = cabeza;
                for (int i = 1; i < posicion; i++)
                {
                    actual = actual.Siguiente; // Mover al nodo en la posición deseada
                }

                actual.Anterior.Siguiente = actual.Siguiente; // Conectar el anterior con el siguiente
                actual.Siguiente.Anterior = actual.Anterior; // Conectar el siguiente con el anterior
                tamaño--; 
            }

            // Método para buscar un valor en la lista y regresara sus posiciones
            public string[] Buscar(string valorBuscado)
            {
                StringBuilder posiciones = new StringBuilder();
                Nodo actual = cabeza;

                int index = 1;
                while (actual != null)
                {
                    if (actual.Valor == valorBuscado)
                    {
                        posiciones.Append(index + ", "); // Almacena la posición en base 1
                    }
                    actual = actual.Siguiente; // Mover al siguiente nodo
                    index++;
                }

                return posiciones.Length > 0
                    ? posiciones.ToString().TrimEnd(',', ' ').Split(',')
                    : Array.Empty<string>();
            }

            // Método para mostrar todos los elementos de la lista
            public string Mostrar()
            {
                if (cabeza == null)
                {
                    return "La lista está vacía.";
                }

                StringBuilder resultado = new StringBuilder();
                Nodo actual = cabeza;

                while (actual != null)
                {
                    resultado.AppendLine(actual.Valor); // Agrega cada elemento a la cadena
                    actual = actual.Siguiente; // Mover al siguiente nodo
                }
                return resultado.ToString(); // Retorna la representación en cadena de la lista
            }

            // Método para vaciar la lista
            public void Vaciar()
            {
                cabeza = null; // Reinicia la cabeza
                cola = null; // Reinicia la cola
                tamaño = 0; // Reinicia el tamaño
            }
        }

        private ListaDoble lista = new ListaDoble();

        // Método para actualizar el contenido del TextBox con los elementos
        private void ActualizarLista()
        {
            textBoxLista1.Text = lista.Mostrar(); // Muestra los elementos en el TextBox
        }

        private void textBoxListaDoble_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar1_Click_1(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento1.Text; // Obtiene el nuevo elemento del TextBox
            if (string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Introduce un elemento válido."); 
                return;
            }

            lista.Agregar(nuevoElemento); // Agrega el elemento a la lista
            ActualizarLista(); // Actualiza el TextBox
            textBoxElemento1.Clear(); // Limpia el TextBox de entrada
        }

        private void buttonVaciarLista1_Click_1(object sender, EventArgs e)
        {
            lista.Vaciar(); // Vacía la lista
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonElimPrim1_Click(object sender, EventArgs e)
        {
            lista.EliminarPrimero(); // Elimina el primer elemento de la lista
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonElimUlt1_Click_1(object sender, EventArgs e)
        {
            lista.EliminarUltimo(); // Elimina el último elemento de la lista
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonInsertarPos1_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento1.Text; // Obtiene el nuevo elemento del TextBox
            if (string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Introduce un elemento válido."); 
                return;
            }

            if (int.TryParse(textBoxPosicion1.Text, out int posicion))
            {
                lista.InsertarEnPosicion(nuevoElemento, posicion); // Inserta el elemento en la posición indicada
                ActualizarLista(); // Actualiza el TextBox
                textBoxElemento1.Clear(); // Limpia el TextBox de entrada
                textBoxPosicion1.Clear(); // Limpia el TextBox de posición
            }
            else
            {
                MessageBox.Show("Introduce una posición válida."); 
            }
        }

        private void buttonElimPos1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPosicion1.Text, out int posicion))
            {
                lista.EliminarEnPosicion(posicion); // Elimina el elemento en la posición indicada
                ActualizarLista(); // Actualiza el TextBox
                textBoxPosicion1.Clear(); // Limpia el TextBox de posición
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }

        private void buttonBus1_Click(object sender, EventArgs e)
        {
            string valorBuscado = textBoxBuscar1.Text; // Obtiene el valor a buscar
            if (string.IsNullOrEmpty(valorBuscado))
            {
                MessageBox.Show("Introduce un valor para buscar."); 
                return;
            }

            string[] posiciones = lista.Buscar(valorBuscado); // Busca el valor en la lista
            if (posiciones.Length == 0)
            {
                MessageBox.Show($"El valor '{valorBuscado}' no se encontró en la lista."); 
            }
            else
            {
                MessageBox.Show($"El valor '{valorBuscado}' se encuentra en las posiciones: {string.Join(", ", posiciones)}"); 
            }
        }
    }
}
