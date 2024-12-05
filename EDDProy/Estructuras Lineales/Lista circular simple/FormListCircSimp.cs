using System;
using System.Text;
using System.Windows.Forms;

namespace EDDEMO
{
    public partial class FormListCircSimp : Form
    {
        public FormListCircSimp()
        {
            InitializeComponent(); 
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        // Clase que representa un nodo 
        public class Nodo
        {
            public string Valor { get; set; } // Valor del nodo
            public Nodo Siguiente { get; set; } // Siguiente nodo

            public Nodo(string valor)
            {
                Valor = valor;
                Siguiente = null; // Inicializa el nodo siguiente como null
            }
        }

        // Clase que representa la lista circular
        public class ListaCircular
        {
            private Nodo cabeza; // Cabeza de la lista
            private int tamaño; // Tamaño de la lista

            public ListaCircular()
            {
                cabeza = null; // Inicializa la cabeza como null
                tamaño = 0; 
            }

            // Método para agregar un elemento al final 
            public void Agregar(string valor)
            {
                Nodo nuevoNodo = new Nodo(valor); 
                if (cabeza == null)
                {
                    cabeza = nuevoNodo; // El nuevo nodo es la cabeza si la lista está vacía
                    nuevoNodo.Siguiente = cabeza; // El siguiente del nuevo nodo apunta a sí mismo
                }
                else
                {
                    Nodo temp = cabeza;
                    while (temp.Siguiente != cabeza) // Busca el último nodo
                    {
                        temp = temp.Siguiente;
                    }
                    temp.Siguiente = nuevoNodo; // Enlaza el nuevo nodo al último nodo
                    nuevoNodo.Siguiente = cabeza; // El nuevo nodo apunta a la cabeza
                }
                tamaño++;
            }

            // Método para eliminar el último elemento de la lista
            public void EliminarUltimo()
            {
                if (cabeza == null) 
                {
                    MessageBox.Show("La lista está vacía."); 
                    return;
                }

                if (cabeza.Siguiente == cabeza) // Si solo hay un nodo
                {
                    cabeza = null; // Elimina el único nodo
                }
                else
                {
                    Nodo temp = cabeza;
                    while (temp.Siguiente.Siguiente != cabeza) // Busca el penúltimo nodo
                    {
                        temp = temp.Siguiente;
                    }
                    temp.Siguiente = cabeza; // Elimina el último nodo
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

                if (cabeza.Siguiente == cabeza) // Si solo hay un nodo
                {
                    cabeza = null; // Elimina el único nodo
                }
                else
                {
                    Nodo temp = cabeza;
                    while (temp.Siguiente != cabeza) // Busca el último nodo
                    {
                        temp = temp.Siguiente;
                    }
                    cabeza = cabeza.Siguiente; // La cabeza se mueve al siguiente nodo
                    temp.Siguiente = cabeza; // El último nodo apunta a la nueva cabeza
                }
                tamaño--;
            }

            // Método para eliminar un elemento en una posición específica
            public void EliminarEnPosicion(int posicion)
            {
                if (cabeza == null) 
                {
                    MessageBox.Show("La lista está vacía."); 
                    return;
                }

                if (posicion < 1 || posicion > tamaño) // Verifica si la posición es válida
                {
                    MessageBox.Show("Posición inválida."); 
                    return;
                }

                if (posicion == 1) // Si se elimina la cabeza
                {
                    EliminarPrimero(); // Llama al método para eliminar el primer nodo
                }
                else
                {
                    Nodo temp = cabeza;
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        temp = temp.Siguiente; // Avanza al nodo anterior al que se va a eliminar
                    }
                    temp.Siguiente = temp.Siguiente.Siguiente; // Elimina el nodo en la posición especificada
                    tamaño--; 
                }
            }

            // Método para insertar un nuevo elemento en una posición
            public void InsertarEnPosicion(string valor, int posicion)
            {
                if (posicion < 1 || posicion > tamaño + 1) // Verifica si la posición es válida
                {
                    MessageBox.Show("Posición inválida.");
                    return;
                }

                Nodo nuevoNodo = new Nodo(valor); // Crea un nuevo nodo

                if (posicion == 1) // Si se inserta al principio
                {
                    if (cabeza == null) 
                    {
                        cabeza = nuevoNodo; // El nuevo nodo es la cabeza
                        nuevoNodo.Siguiente = cabeza; // El siguiente del nuevo nodo apunta a sí mismo
                    }
                    else
                    {
                        Nodo temp = cabeza;
                        while (temp.Siguiente != cabeza) // Busca el último nodo
                        {
                            temp = temp.Siguiente;
                        }
                        temp.Siguiente = nuevoNodo; // El último nodo apunta al nuevo nodo
                        nuevoNodo.Siguiente = cabeza; // El nuevo nodo apunta a la cabeza
                        cabeza = nuevoNodo; // La cabeza se actualiza
                    }
                }
                else
                {
                    Nodo temp = cabeza;
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        temp = temp.Siguiente; // Avanza al nodo anterior
                    }
                    nuevoNodo.Siguiente = temp.Siguiente; // El nuevo nodo apunta al siguiente
                    temp.Siguiente = nuevoNodo; // El nodo anterior apunta al nuevo nodo
                }

                tamaño++;
            }

            // Método para buscar un valor y regresar sus posiciones
            public string[] Buscar(string valorBuscado)
            {
                if (cabeza == null) return Array.Empty<string>(); // Regresa un arreglo vacío si está vacía

                StringBuilder posiciones = new StringBuilder();
                Nodo temp = cabeza;
                int index = 1;

                do
                {
                    if (temp.Valor == valorBuscado)
                    {
                        posiciones.Append(index + ", "); // Almacena la posición en base 1
                    }
                    temp = temp.Siguiente; // Avanza al siguiente nodo
                    index++;
                } while (temp != cabeza); // Continua hasta que regrese a la cabeza

                return posiciones.Length > 0
                    ? posiciones.ToString().TrimEnd(',', ' ').Split(',')
                    : Array.Empty<string>();
            }

            // Método para vaciar la lista
            public void Vaciar()
            {
                cabeza = null; // Reinicia la cabeza a null
                tamaño = 0; // Reinicia el tamaño
            }

            // Método para mostrar todos los elementos 
            public string Mostrar()
            {
                if (cabeza == null)
                {
                    return "La lista está vacía."; 
                }

                StringBuilder resultado = new StringBuilder();
                Nodo temp = cabeza;
                do
                {
                    resultado.AppendLine(temp.Valor); // Agrega cada elemento a la cadena
                    temp = temp.Siguiente; // Avanza al siguiente nodo
                } while (temp != cabeza); // Continua hasta que regrese a la cabeza

                return resultado.ToString(); // Retorna la representación de la lista
            }
        }

        private ListaCircular lista = new ListaCircular();

        // Método para actualizar el contenido del TextBox con los elementos 
        private void ActualizarLista()
        {
            textBoxLista2.Text = lista.Mostrar(); // Muestra los elementos en el TextBox
        }

        private void buttonAgregar2_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento2.Text; // Obtiene el nuevo elemento del TextBox
            if (string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Introduce un elemento válido."); 
                return;
            }

            lista.Agregar(nuevoElemento); // Agrega el elemento a la lista
            ActualizarLista(); // Actualiza el TextBox
            textBoxElemento2.Clear(); // Limpia el TextBox 
        }

        private void buttonVaciarLista2_Click(object sender, EventArgs e)
        {
            lista.Vaciar(); // Vacía la lista
            ActualizarLista(); // Actualiza el Textbox
        }

        private void buttonElimPrim2_Click(object sender, EventArgs e)
        {
            lista.EliminarPrimero(); // Elimina el primer elemento de la lista
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonElimUlt3_Click(object sender, EventArgs e)
        {
            lista.EliminarUltimo(); // Elimina el último elemento de la lista
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonElimPos2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPosicion2.Text, out int posicion))
            {
                lista.EliminarEnPosicion(posicion); // Elimina el elemento en la posición indicada
                ActualizarLista(); // Actualiza el TextBox
                textBoxPosicion2.Clear(); // Limpia el TextBox 
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }

        private void buttonInsertarPos2_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento2.Text; // Obtiene el nuevo elemento del TextBox
            if (string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Introduce un elemento válido."); 
                return;
            }

            if (int.TryParse(textBoxPosicion2.Text, out int posicion))
            {
                lista.InsertarEnPosicion(nuevoElemento, posicion); // Inserta el elemento en la posición indicada
                ActualizarLista(); // Actualiza el TextBox
                textBoxElemento2.Clear(); // Limpia el TextBox 
                textBoxPosicion2.Clear(); // Limpia el TextBox 
            }
            else
            {
                MessageBox.Show("Introduce una posición válida."); 
            }
        }

        private void buttonBus2_Click(object sender, EventArgs e)
        {
            string valorBuscado = textBoxElemento2.Text; // Obtiene el valor a buscar
            if (string.IsNullOrEmpty(valorBuscado))
            {
                MessageBox.Show("Introduce un elemento válido para buscar."); 
                return;
            }

            string[] posicionesEncontradas = lista.Buscar(valorBuscado); // Busca el valor en la lista
            if (posicionesEncontradas.Length > 0)
            {
                MessageBox.Show("Elemento encontrado en las posiciones: " + string.Join(", ", posicionesEncontradas)); // Muestra las posiciones encontradas
            }
            else
            {
                MessageBox.Show("Elemento no encontrado."); 
            }
        }
    }
}
