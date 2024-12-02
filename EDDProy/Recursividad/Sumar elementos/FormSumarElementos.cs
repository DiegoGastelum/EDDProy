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
    public partial class FormSumarElementos : Form
    {
        public FormSumarElementos()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSumTailRecursive_Click_1(object sender, EventArgs e)
        {
            // Leer el texto de la caja de texto y separar los números por comas
            string inputText = textBoxInput.Text;
            string[] stringNumbers = inputText.Split(',');

            try
            {
                // Convertir los elementos del arreglo a enteros
                int[] numbers = stringNumbers.Select(s => int.Parse(s.Trim())).ToArray();

                // Inicializar el contador de operaciones
                int operations = 0;

                // Medir el tiempo de ejecución
                var stopwatch = Stopwatch.StartNew();

                // Sumar los elementos de forma recursiva de cola
                int sum = SumArrayTailRecursive(numbers, numbers.Length, 0, ref operations);

                stopwatch.Stop();

                // Mostrar el resultado
                labelResult2.Text = $"El resultado es: {sum}";
                labelTime2.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds} ms";
                labelOperations2.Text = $"Total de operaciones: {operations}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos separados por comas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int SumArrayTailRecursive(int[] numbers, int count, int accumulator, ref int operations)
        {
            // Incrementar el contador de operaciones
            operations++;

            // Caso base: si no hay más elementos
            if (count <= 0)
                return accumulator;

            // Caso recursivo (recursividad de cola)
            return SumArrayTailRecursive(numbers, count - 1, accumulator + numbers[count - 1], ref operations);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
