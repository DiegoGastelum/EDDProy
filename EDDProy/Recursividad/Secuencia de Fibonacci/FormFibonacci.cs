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

namespace WindowsFormsApp1
{
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer el número de la caja de texto
            if (!int.TryParse(textBoxNumero.Text, out int n) || n < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero no negativo.");
                return;
            }

            // Inicializar el contador de operaciones
            int operations = 0;

            // Medir el tiempo de ejecución
            var stopwatch = Stopwatch.StartNew();

            // Calcular el número de Fibonacci usando recursión de cola
            long result = FibonacciTailRecursive(n, 0, 1, ref operations);

            stopwatch.Stop();

            // Mostrar el resultado
            labelResult3.Text = $"El resultado es: {result}";
            labelTime3.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds} ms";
            labelOperations3.Text = $"Total de operaciones: {operations}";
        }

        private long FibonacciTailRecursive(int n, long a, long b, ref int operations)
        {
            // Incrementar el contador de operaciones
            operations++;

            // Caso base
            if (n == 0)
                return a;
            if (n == 1)
                return b;

            // Caso recursivo (recursividad de cola)
            return FibonacciTailRecursive(n - 1, b, a + b, ref operations);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
