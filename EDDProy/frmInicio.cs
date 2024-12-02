using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Búsqueda;
using EDDemo.Estructuras_No_Lineales;
using EDDEMO;
using QuickSortApp;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ColasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColas form10 = new FormColas();
            form10.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListSimp form11 = new FormListSimp();
            form11.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListDoble form12 = new FormListDoble();
            form12.Show();
        }

        private void listaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListCircSimp form13 = new FormListCircSimp();
            form13.Show();
        }

        private void listaCircularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListCircDoble formListCircDoble = new FormListCircDoble();
            formListCircDoble.Show();
        }

        private void quicksortToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Formquicksort formquicksort = new Formquicksort();
            formquicksort.Show();
        }

        private void binariaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Búsqueda.FormBusqBinaria formBusqBinaria = new Búsqueda.FormBusqBinaria();
            formBusqBinaria.Show();
        }

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactorial form2 = new FormFactorial();  
            form2.Show();
        }
        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExponente form3 = new FormExponente();
            form3.Show();
        }

        private void sumarElementosDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSumarElementos form4 = new FormSumarElementos();
            form4.Show();
        }

        private void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci form5 = new FormFibonacci();
            form5.Show();
        }

        private void búsquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusqBinaria formBusq = new FormBusqBinaria();
            formBusq.Show();
        }

        private void torreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHanoi form7 = new FormHanoi();
            form7.Show();
        }
    }
}
