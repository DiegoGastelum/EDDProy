using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace QuickSortApp
{
    public partial class Formquicksort : Form
    {
        private int[] arreglo;

        public Formquicksort()
        {
            InitializeComponent();
        }

        private void QuickSort(int[] A, int inf, int sup)
        {
            int i = inf;
            int j = sup;
            int x = A[(inf + sup) / 2]; // Pivote

            do
            {
                while (A[i] < x) i++;
                while (A[j] > x) j--;

                if (i <= j)
                {
                    // Intercambiar A[i] y A[j]
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;

                    i++;
                    j--;
                }
            } while (i <= j);

            // Llamadas recursivas
            if (inf < j) QuickSort(A, inf, j);
            if (i < sup) QuickSort(A, i, sup);
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            // Generar un arreglo aleatorio con menos de 50 datos
            Random rnd = new Random();
            int size = rnd.Next(2, 50); // Entre 2 y 50 elementos
            arreglo = new int[size];
            for (int i = 0; i < size; i++)
            {
                arreglo[i] = rnd.Next(1, 100); // Valores entre 1 y 100
            }

            // Mostrar el arreglo original
            lblArregloOriginal.Text = string.Join(", ", arreglo);
            lblArregloOrdenado.Text = "...";
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el usuario ingresó valores manuales 
                if (!string.IsNullOrWhiteSpace(txtArregloManual.Text))
                {
                    // Validar entrada del usuario
                    if (!txtArregloManual.Text.All(c => char.IsDigit(c) || c == ',' || char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("Ingresa solo números separados por comas.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Convertir los valores a un arreglo de enteros
                    arreglo = txtArregloManual.Text
                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(val => int.Parse(val.Trim()))
                        .ToArray();

                    // Mostrar el arreglo original
                    lblArregloOriginal.Text = string.Join(", ", arreglo);
                }

                if (arreglo != null && arreglo.Length > 0)
                {
                    // Iniciar el cronómetro
                    Stopwatch stopwatch = Stopwatch.StartNew();

                    QuickSort(arreglo, 0, arreglo.Length - 1);

                    // Detener el cronómetro
                    stopwatch.Stop();

                    // Mostrar el arreglo ordenado
                    lblArregloOrdenado.Text =  string.Join(", ", arreglo);

                    // Limpiar la TextBox después de ordenar
                    txtArregloManual.Text = "";

                    // Mostrar el tiempo de ejecución en segundos 
                    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
                    lbltime.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds} ms";
                }
                else
                {
                    MessageBox.Show("Primero genera o ingresa un arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el arreglo. Asegúrate de ingresar valores válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
