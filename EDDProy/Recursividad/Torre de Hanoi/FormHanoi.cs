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
    public partial class FormHanoi : Form
    {
        public FormHanoi()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer el número de discos desde el cuadro de texto
            if (!int.TryParse(textBoxDisks.Text, out int numberOfDisks) || numberOfDisks <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido de discos (mayor que 0).");
                return;
            }

            // Advertencia si el número de discos es mayor a 15
            if (numberOfDisks >= 15)
            {
                MessageBox.Show("Advertencia: El número de discos no debe exceder de 15, ya que el número de operaciones crece exponencialmente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inicializar el contador de operaciones
            int operations = 0;

            // Iniciar el cronómetro para medir el tiempo de ejecución
            var stopwatch = Stopwatch.StartNew();

            // Iniciar el algoritmo de las Torres de Hanoi
            SolveHanoi(numberOfDisks, 'A', 'C', 'B', ref operations);

            // Detener el cronómetro
            stopwatch.Stop();

            // Mostrar el número de operaciones (movimientos) y el tiempo de ejecución
            labelTime3.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds} ms";
            labelOperations3.Text = $"Total de operaciones: {operations}";
        }
        // Método recursivo para resolver las Torres de Hanoi
        private void SolveHanoi(int n, char fromRod, char toRod, char auxRod, ref int operations)
        {
            // Caso base
            if (n == 1)
            {
                textBoxResult.AppendText($"Mover disco 1 de {fromRod} a {toRod}\n");
                operations++;  // Contar el movimiento
                return;
            }

            // Mover n-1 discos de la varilla origen a la varilla auxiliar
            SolveHanoi(n - 1, fromRod, auxRod, toRod, ref operations);

            // Mover el disco n de la varilla origen a la varilla destino
            textBoxResult.AppendText($"Mover disco {n} de {fromRod} a {toRod}\n");
            operations++;  // Contar el movimiento

            // Mover los n-1 discos de la varilla auxiliar a la varilla destino
            SolveHanoi(n - 1, auxRod, toRod, fromRod, ref operations);
        }
    }
}
