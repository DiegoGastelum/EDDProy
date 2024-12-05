using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class FormBusqBinaria : Form
    {
        public FormBusqBinaria()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer el número a buscar y el arreglo desde las cajas de texto
            if (!int.TryParse(textBoxSearchValue.Text, out int searchValue))
            {
                MessageBox.Show("Ingresa un número válido para buscar.");
                return;
            }

            int[] numbers;
            try
            {
                // Convertir los elementos del arreglo a enteros y ordenar el arreglo
                string[] stringNumbers = textBoxArray.Text.Split(',');
                numbers = stringNumbers.Select(s => int.Parse(s.Trim())).OrderBy(n => n).ToArray();
            }
            catch (FormatException)
            {
                MessageBox.Show("El arreglo debe contener solo números válidos separados por comas.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el arreglo: {ex.Message}");
                return;
            }

            // Inicializar el contador de operaciones
            int operations = 0;

            // Medir el tiempo de ejecución
            var stopwatch = Stopwatch.StartNew();

            // Realizar la búsqueda binaria
            int index = BinarySearch(numbers, searchValue, 0, numbers.Length - 1, ref operations);

            stopwatch.Stop();

            // Mostrar el resultado
            if (index >= 0)
                labelResult4.Text = $"El valor {searchValue} se encuentra en el índice {index}.";
            else
                labelResult4.Text = $"El valor {searchValue} no se encontró en el arreglo.";

            // Mostrar el tiempo de ejecución y el número de operaciones
            labelTime4.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds} ms";
            labelOperations4.Text = $"Total de operaciones: {operations}";
        }

        private int BinarySearch(int[] array, int searchValue, int left, int right, ref int operations)
        {
            // Incrementar el contador de operaciones
            operations++;

            // Caso base: Si el rango es inválido
            if (left > right)
                return -1; // No encontrado

            // Encontrar el punto medio
            int mid = left + (right - left) / 2;

            // Comparar el valor medio con el valor buscado
            if (array[mid] == searchValue)
                return mid; // Encontrado
            else if (array[mid] > searchValue)
                // Buscar en la mitad izquierda
                return BinarySearch(array, searchValue, left, mid - 1, ref operations);
            else
                // Buscar en la mitad derecha
                return BinarySearch(array, searchValue, mid + 1, right, ref operations);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}