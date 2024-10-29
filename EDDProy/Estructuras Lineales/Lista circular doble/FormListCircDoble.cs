using System;
using System.Text;
using System.Windows.Forms;

namespace EDDEMO
{
    public partial class FormListCircDoble : Form
    {
        public FormListCircDoble()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void FormListCircDoble_Load(object sender, EventArgs e)
        {

        }

        // Clase que representa un nodo 
        public class Nodo
        {
            public string Valor { get; set; } 
            public Nodo Siguiente { get; set; } 
            public Nodo Anterior { get; set; } 

            public Nodo(string valor)
            {
                Valor = valor;
                Siguiente = null; // Inicializa el nodo como null
                Anterior = null; // Inicializa el nodo como null
            }
        }

        // Clase que representa la lista 
        public class ListaCircularDoble
        {
            private Nodo cabeza; // Cabeza de la lista
            private Nodo cola;   // Cola de la lista
            private int tamaño;  // Tamaño de la lista

            public ListaCircularDoble()
            {
                cabeza = null; // Inicializa la cabeza como null
                cola = null;   // Inicializa la cola como null
                tamaño = 0;    // Inicializa el tamaño en 0
            }

            // Método para agregar un nuevo elemento al final 
            public void Agregar(string valor)
            {
                Nodo nuevoNodo = new Nodo(valor); // Crea un nuevo nodo
                if (cabeza == null)
                {
                    cabeza = nuevoNodo;
                    cola = nuevoNodo;
                    cabeza.Siguiente = cabeza; 
                    cabeza.Anterior = cola;
                }
                else
                {
                    cola.Siguiente = nuevoNodo; // La cola apunta al nuevo nodo
                    nuevoNodo.Anterior = cola;  // El nuevo nodo apunta a la cola anterior
                    nuevoNodo.Siguiente = cabeza; // El nuevo nodo apunta a la cabeza
                    cabeza.Anterior = nuevoNodo;  // La cabeza apunta al nuevo nodo
                    cola = nuevoNodo; // Actualiza la cola
                }
                tamaño++; 
            }

            // Método para eliminar el último elemento 
            public void EliminarUltimo()
            {
                if (cabeza == null)
                {
                    MessageBox.Show("La lista está vacía.");
                    return;
                }

                if (cabeza == cola) // Si solo hay un nodo
                {
                    cabeza = null;
                    cola = null;
                }
                else
                {
                    cola = cola.Anterior;  // La cola se mueve al nodo anterior
                    cola.Siguiente = cabeza; // La cola apunta a la cabeza
                    cabeza.Anterior = cola;  // La cabeza apunta a la cola
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

                if (cabeza == cola)
                {
                    cabeza = null;
                    cola = null;
                }
                else
                {
                    cabeza = cabeza.Siguiente; // La cabeza se mueve al siguiente nodo
                    cabeza.Anterior = cola;    // La nueva cabeza apunta a la cola
                    cola.Siguiente = cabeza;   // La cola apunta a la nueva cabeza
                }
                tamaño--;
            }

            // Método para eliminar un elemento en una posición 
            public void EliminarEnPosicion(int posicion)
            {
                if (cabeza == null)
                {
                    MessageBox.Show("La lista está vacía.");
                    return;
                }

                if (posicion < 1 || posicion > tamaño)
                {
                    MessageBox.Show("Posición inválida.");
                    return;
                }

                if (posicion == 1)
                {
                    EliminarPrimero();
                }
                else if (posicion == tamaño)
                {
                    EliminarUltimo();
                }
                else
                {
                    Nodo temp = cabeza;
                    for (int i = 1; i < posicion; i++)
                    {
                        temp = temp.Siguiente;
                    }
                    temp.Anterior.Siguiente = temp.Siguiente; // Conecta el nodo anterior con el siguiente
                    temp.Siguiente.Anterior = temp.Anterior;  // Conecta el nodo siguiente con el anterior
                    tamaño--;
                }
            }

            // Método para insertar un nuevo elemento en cualquier posición 
            public void InsertarEnPosicion(string valor, int posicion)
            {
                if (posicion < 1 || posicion > tamaño + 1)
                {
                    MessageBox.Show("Posición inválida.");
                    return;
                }

                Nodo nuevoNodo = new Nodo(valor);

                if (posicion == 1) // Insertar al inicio
                {
                    if (cabeza == null)
                    {
                        cabeza = nuevoNodo;
                        cola = nuevoNodo;
                        cabeza.Siguiente = cabeza;
                        cabeza.Anterior = cola;
                    }
                    else
                    {
                        nuevoNodo.Siguiente = cabeza;
                        nuevoNodo.Anterior = cola;
                        cabeza.Anterior = nuevoNodo;
                        cola.Siguiente = nuevoNodo;
                        cabeza = nuevoNodo;
                    }
                }
                else if (posicion == tamaño + 1) // Insertar al final
                {
                    Agregar(valor);
                }
                else
                {
                    Nodo temp = cabeza;
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        temp = temp.Siguiente;
                    }
                    nuevoNodo.Siguiente = temp.Siguiente;
                    nuevoNodo.Anterior = temp;
                    temp.Siguiente.Anterior = nuevoNodo;
                    temp.Siguiente = nuevoNodo;
                }

                tamaño++;
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
                    resultado.AppendLine(temp.Valor); // Agrega cada valor a la cadena
                    temp = temp.Siguiente;
                } while (temp != cabeza); // Continua hasta volver a la cabeza

                return resultado.ToString();
            }

            // Método para vaciar la lista
            public void Vaciar()
            {
                cabeza = null;
                cola = null;
                tamaño = 0;
            }

            // Método para buscar un valor y devolver las posiciones encontradas
            public string[] Buscar(string valorBuscado)
            {
                if (cabeza == null) return Array.Empty<string>(); // Regresa un arreglo vacío si la lista está vacía

                StringBuilder posiciones = new StringBuilder();
                Nodo temp = cabeza;
                int index = 1;

                do
                {
                    if (temp.Valor == valorBuscado)
                    {
                        posiciones.Append(index + ", "); // Almacena la posición
                    }
                    temp = temp.Siguiente;
                    index++;
                } while (temp != cabeza); // Continúa hasta que regrese a la cabeza

                // Retorna las posiciones encontradas o un arreglo vacío si no encontró el valor
                return posiciones.Length > 0
                    ? posiciones.ToString().TrimEnd(',', ' ').Split(',')
                    : Array.Empty<string>();
            }
        }

        private ListaCircularDoble lista = new ListaCircularDoble();

        private void ActualizarLista()
        {
            textBoxLista3.Text = lista.Mostrar();
        }

        private void buttonAgregar3_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento3.Text;
            if (string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Introduce un elemento válido.");
                return;
            }

            lista.Agregar(nuevoElemento);
            ActualizarLista();
            textBoxElemento3.Clear();
        }

        private void buttonVaciarLista3_Click(object sender, EventArgs e)
        {
            lista.Vaciar();
            ActualizarLista();
        }

        private void buttonElimPrim3_Click(object sender, EventArgs e)
        {
            lista.EliminarPrimero();
            ActualizarLista();
        }

        private void buttonElimUlt4_Click(object sender, EventArgs e)
        {
            lista.EliminarUltimo();
            ActualizarLista();
        }

        private void buttonInsertarPos3_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento3.Text;
            if (string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Introduce un elemento válido.");
                return;
            }

            if (int.TryParse(textBoxPosicion3.Text, out int posicion))
            {
                lista.InsertarEnPosicion(nuevoElemento, posicion);
                ActualizarLista();
                textBoxElemento3.Clear();
                textBoxPosicion3.Clear();
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }

        private void buttonElimPos3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPosicion3.Text, out int posicion))
            {
                lista.EliminarEnPosicion(posicion);
                ActualizarLista();
                textBoxPosicion3.Clear();
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }

        private void buttonBus3_Click(object sender, EventArgs e)
        {
            string valorBuscado = textBoxElemento3.Text;
            if (string.IsNullOrEmpty(valorBuscado))
            {
                MessageBox.Show("Introduce un elemento válido para buscar.");
                return;
            }

            string[] posicionesEncontradas = lista.Buscar(valorBuscado);
            if (posicionesEncontradas.Length > 0)
            {
                MessageBox.Show("Elemento encontrado en las posiciones: " + string.Join(", ", posicionesEncontradas));
            }
            else
            {
                MessageBox.Show("Elemento no encontrado.");
            }
        }
    }
}
