using System;
using System.Diagnostics;
using System.Numerics; // Necesario para BigInteger
using System.Windows.Forms;

namespace EDDemo
{
    public partial class FormExponente : Form
    {
        public FormExponente()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Cualquier inicialización necesaria cuando se carga el formulario
        }
        private void buttonCalculate1_Click_1(object sender, EventArgs e)
        {
            // Leer el número base y el exponente de las cajas de diálogo
            if (!int.TryParse(textBase.Text, out int baseNumber) || baseNumber < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo para la base.");
                return;
            }

            if (!int.TryParse(textExponent.Text, out int exponent) || exponent < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo para el exponente.");
                return;
            }

            // Inicializar el contador de operaciones
            int operations = 0;

            // Medir el tiempo de ejecución
            var stopwatch = Stopwatch.StartNew();

            // Calcular la base elevada al exponente
            long result = CalculatePower(baseNumber, exponent, ref operations);

            stopwatch.Stop();

            // Mostrar el resultado
            labelResult1.Text = $"El resultado es: {baseNumber}^{exponent} = {result}";
            labelTime1.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds} ms";
            labelOperations1.Text = $"Total de operaciones: {operations}";
        }

        private long CalculatePower(int baseNumber, int exponent, ref int operations)
        {
            // Incrementar el contador de operaciones
            operations++;

            // Caso base
            if (exponent == 0)
                return 1;

            // Caso recursivo
            return baseNumber * CalculatePower(baseNumber, exponent - 1, ref operations);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}