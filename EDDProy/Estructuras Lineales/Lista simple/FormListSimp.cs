using System;
using System.Text;
using System.Windows.Forms;

namespace EDDEMO
{
    public partial class FormListSimp : Form
    {
        public FormListSimp()
        {
            InitializeComponent(); 
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        // Clase que representa un nodo de la lista enlazada
        public class Nodo
        {
            public string valor; 
            public Nodo siguiente; 

            // Constructor del nodo que inicializa el valor y establece el siguiente nodo a null
            public Nodo(string valor)
            {
                this.valor = valor;
                this.siguiente = null; // Inicialmente el siguiente nodo es null
            }
        }

        // Clase que representa la lista 
        public class ListaSimple
        {
            private Nodo cabeza; // Nodo inicial de la lista

            // Constructor que inicializa la lista como vacía
            public ListaSimple()
            {
                cabeza = null; 
            }

            // Método para agregar un nuevo elemento al final
            public void Agregar(string valor)
            {
                Nodo nuevoNodo = new Nodo(valor); // Crear un nuevo nodo con el valor dado

                if (cabeza == null) // Si la lista está vacía, el nuevo nodo es la cabeza
                {
                    cabeza = nuevoNodo;
                }
                else
                {
                    Nodo actual = cabeza;
                    // Recorre la lista hasta el último nodo
                    while (actual.siguiente != null)
                    {
                        actual = actual.siguiente;
                    }
                    actual.siguiente = nuevoNodo; // Añadir el nuevo nodo al final 
                }
            }

            // Método para eliminar el último elemento 
            public void EliminarUltimo()
            {
                if (cabeza == null) // Si la lista está vacía
                {
                    MessageBox.Show("La lista está vacía.");
                    return;
                }

                if (cabeza.siguiente == null) 
                {
                    cabeza = null;
                }
                else
                {
                    Nodo actual = cabeza;
                    // Recorrer la lista hasta el penúltimo nodo
                    while (actual.siguiente.siguiente != null)
                    {
                        actual = actual.siguiente;
                    }
                    actual.siguiente = null; // Eliminar la referencia al último nodo
                }
            }

            // Método para eliminar el primer elemento 
            public void EliminarPrimero()
            {
                if (cabeza != null) // Si la lista no está vacía
                {
                    cabeza = cabeza.siguiente; // La cabeza apunta al segundo nodo
                }
                else
                {
                    MessageBox.Show("La lista está vacía.");
                }
            }

            // Método para eliminar un elemento en una posición
            public void EliminarEnPosicion(int posicion)
            {
                if (posicion < 1 || cabeza == null) // Verificar si la posición es inválida
                {
                    MessageBox.Show("Posición inválida.");
                    return;
                }

                if (posicion == 1) // Si es la primera posición
                {
                    cabeza = cabeza.siguiente; // La cabeza pasa al siguiente nodo
                    return;
                }

                Nodo actual = cabeza;
                int contador = 1;
                // Recorrer hasta el nodo anterior a la posición
                while (contador < posicion - 1 && actual.siguiente != null)
                {
                    actual = actual.siguiente;
                    contador++;
                }

                if (actual.siguiente == null) 
                {
                    MessageBox.Show("Posición inválida.");
                }
                else
                {
                    actual.siguiente = actual.siguiente.siguiente; // Saltar el nodo a eliminar
                }
            }

            // Método para buscar un valor y retornar sus posiciones
            public string[] Buscar(string valorBuscado)
            {
                StringBuilder posiciones = new StringBuilder();
                Nodo actual = cabeza;
                int posicion = 1;

                // Recorrer la lista buscando coincidencias
                while (actual != null)
                {
                    if (actual.valor == valorBuscado) // Si se encuentra el valor
                    {
                        posiciones.Append(posicion + ", "); // Almacenar la posición (base 1)
                    }
                    actual = actual.siguiente;
                    posicion++;
                }

                // Si se encuentran coincidencias, devolver las posiciones o un arreglo vacío
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

                // Recorrer la lista y agregar cada valor al resultado
                while (actual != null)
                {
                    resultado.AppendLine(actual.valor); // Agrega cada valor
                    actual = actual.siguiente;
                }

                return resultado.ToString();
            }

            // Método para vaciar la lista
            public void Vaciar()
            {
                cabeza = null; // Simplemente establece la cabeza en null para vaciarla
            }

            // Método para insertar un nuevo elemento en una posición 
            public void InsertarEnPosicion(string valor, int posicion)
            {
                Nodo nuevoNodo = new Nodo(valor);

                if (posicion < 1) // Verificar si la posición es inválida
                {
                    MessageBox.Show("Posición inválida.");
                    return;
                }

                if (posicion == 1) // Si se quiere insertar en la cabeza
                {
                    nuevoNodo.siguiente = cabeza; // El nuevo nodo apunta al antiguo primer nodo
                    cabeza = nuevoNodo; // El nuevo nodo se convierte en la cabeza
                    return;
                }

                Nodo actual = cabeza;
                int contador = 1;

                // Recorrer hasta el nodo anterior a la posición deseada
                while (contador < posicion - 1 && actual != null)
                {
                    actual = actual.siguiente;
                    contador++;
                }

                if (actual == null) // Si no se encontró una posición válida
                {
                    MessageBox.Show("Posición inválida.");
                }
                else
                {
                    nuevoNodo.siguiente = actual.siguiente; // El nuevo nodo apunta al siguiente nodo
                    actual.siguiente = nuevoNodo; // El nodo anterior apunta al nuevo nodo
                }
            }
        }

        private ListaSimple lista = new ListaSimple();

        // Método para actualizar el TextBox con los elementos
        private void ActualizarLista()
        {
            textBoxLista.Text = lista.Mostrar(); 
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento.Text;
            if (string.IsNullOrEmpty(nuevoElemento)) // Validar si está vacío
            {
                MessageBox.Show("Introduce un elemento válido.");
                return;
            }

            lista.Agregar(nuevoElemento); // Agrega el elemento a la lista
            ActualizarLista(); // Actualiza el TextBox
            textBoxElemento.Clear(); // Limpia el TextBox
        }

        private void buttonVaciarLista_Click(object sender, EventArgs e)
        {
            lista.Vaciar(); // Vacía la lista
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonElimPrim_Click(object sender, EventArgs e)
        {
            lista.EliminarPrimero(); // Elimina el primer elemento
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonElimUlt_Click(object sender, EventArgs e)
        {
            lista.EliminarUltimo(); // Elimina el último elemento
            ActualizarLista(); // Actualiza el TextBox
        }

        private void buttonElimPos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPosicion.Text, out int posicion)) // Validar la posición 
            {
                lista.EliminarEnPosicion(posicion); // Elimina el elemento en la posición indicada
                ActualizarLista(); // Actualiza el TextBox
                textBoxPosicion.Clear(); // Limpia el TextBox
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }

        private void buttonBusc_Click(object sender, EventArgs e)
        {
            string valorBuscado = textBoxBuscar.Text;
            if (string.IsNullOrEmpty(valorBuscado)) // Validar si el campo está vacío
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

        private void buttonInsertarPos_Click_1(object sender, EventArgs e)
        {
            string nuevoElemento = textBoxElemento.Text;
            if (string.IsNullOrEmpty(nuevoElemento)) // 
            {
                MessageBox.Show("Introduce un elemento válido.");
                return;
            }

            if (int.TryParse(textBoxPosicion.Text, out int posicion)) // Validar la posición 
            {
                lista.InsertarEnPosicion(nuevoElemento, posicion); // Insertar el elemento en la posición 
                ActualizarLista(); // Actualizar el TextBox
                textBoxElemento.Clear(); // Limpiar el TextBox
                textBoxPosicion.Clear(); // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }
    }
}
