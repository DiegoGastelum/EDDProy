using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class FormBusqBinaria2 : Form
    {
        private int[] arreglo;

        public FormBusqBinaria2()
        {
            InitializeComponent();
        }

        // Implementación de la búsqueda binaria
        private int BusquedaBinaria(int[] arreglo, int elemento)
        {
            int inicio = 0, fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (arreglo[medio] == elemento) return medio;
                if (arreglo[medio] < elemento) inicio = medio + 1;
                else fin = medio - 1;
            }

            return -1;
        }

        // Muestra el arreglo en el TextBox
        private void MostrarArreglo()
        {
            txtArreglo.Text = string.Join(", ", arreglo);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (arreglo == null)
            {
                // Asegura que el arreglo esté generado y ordenado antes de la búsqueda
                MessageBox.Show("Genera un arreglo ordenado.", "Advertencia");
                return;
            }

            // Valida que el número ingresado sea válido
            if (int.TryParse(txtElemento.Text, out int elemento))
            {
                // Inicializa el Stopwatch para medir el tiempo de ejecución
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();  // Inicia el cronómetro

                // Realiza la búsqueda binaria
                int resultado = BusquedaBinaria(arreglo, elemento);

                // Detiene el cronómetro
                stopwatch.Stop();

                // Muestra el tiempo de ejecución en la etiqueta
                lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4} ms";

                // Muestra el mensaje dependiendo del resultado de la búsqueda
                string mensaje = resultado != -1
                    ? $"Elemento encontrado en la posición {resultado + 1}."
                    : "Elemento no encontrado.";

                MessageBox.Show(mensaje);  // Muestra si el elemento fue encontrado o no
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.", "Advertencia");
            }
        }

        // Genera un arreglo aleatorio de 10 números
        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            arreglo = new int[10];  // Crear el arreglo con 10 elementos

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = random.Next(1, 100);  // Generar números entre 1 y 100
            }

            MostrarArreglo();  // Mostrar el arreglo en el TextBox
        }

        // Ordena el arreglo ingresado o generado
        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArreglo.Text))
            {
                MessageBox.Show("Ingresa un arreglo o genera uno.", "Advertencia");
                return;
            }

            try
            {
                arreglo = txtArreglo.Text.Split(',')
                    .Select(numero => int.Parse(numero.Trim()))
                    .ToArray();
                Array.Sort(arreglo);
                MostrarArreglo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa números válidos separados por comas.", "Advertencia");
            }
        }

        // Resetea el formulario
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtElemento.Clear();
            txtArreglo.Clear();
            lblTiempo.Text = string.Empty;
            arreglo = null;
        }
    }
}
