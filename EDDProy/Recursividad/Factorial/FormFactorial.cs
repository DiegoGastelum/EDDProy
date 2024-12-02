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
using System.Numerics;

namespace WindowsFormsApp1
{
    public partial class FormFactorial : Form
    {
        public FormFactorial()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            {
                // Leer el número de la caja de diálogo 
                if (!int.TryParse(textBox2.Text, out int number) || number < 0)
                {
                    MessageBox.Show("Por favor, ingrese un número entero positivo.");
                    return;
                }
                if (number >= 24)
                {
                    MessageBox.Show("El número debe ser 23 o menor para evitar problemas de desbordamiento.");
                    return;
                }

                int operations = 0;

                // Medir el tiempo de ejecución
                var stopwatch = Stopwatch.StartNew();

                // Calcular el factorial
                long factorial = CalculateFactorial(number, ref operations);

                stopwatch.Stop();

                // Mostrar el resultado
                labelResult.Text = $"El resultado es: {factorial}";
                labelTime.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds} ms";
                labelOperations.Text = $"Total de operaciones: {operations}";
            }
        }
        private long CalculateFactorial(int number, ref int operations)
        {
            operations++;
            // Caso base
            if (number == 0 || number == 1)
                return 1;
            // Caso recursivo
            return number * CalculateFactorial(number - 1, ref operations);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
