using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";


        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            // Verifica si el árbol está vacío
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Realiza la poda del árbol
            miArbol.PodarArbol(ref miRaiz);

            // Actualiza la visualización del árbol en el formulario
            miArbol.strArbol = "";
            txtArbol.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            StringBuilder b = new StringBuilder();

            b.Append("digraph G { node [shape=\"circle\"]; rankdir=LR; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            // Genera la imagen del arbol
            Bitmap bm = FileDotEngine.Run(graphVizString);

            // Muestra la gráfica en el formulario
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                lblRecorridoInOrden.Text = "El arbol esta vacio";
                lblRecorridoPostOrden1.Text = "El arbol esta vacio";
                lblAltura.Text = "El arbol esta vacio";
                lblHojas.Text = "El arbol esta vacio";
                lblArbolCompleto.Text = "El arbol esta vacio";
                lblRecorridoNiveles.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden1.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden1.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden1.Text = miArbol.strRecorrido;

            //Calcular y mostrar la altura del árbol
            int altura = miArbol.ObtenerAltura(miRaiz);
            lblAltura.Text = altura.ToString();

            // Contar las hojas del árbol
            int numeroHojas = miArbol.ContarHojas(miRaiz);
            lblHojas.Text = numeroHojas.ToString();

            // Contar los nodos del árbol
            int numeroNodos = miArbol.ContarNodos(miRaiz);
            lblNodos.Text = numeroNodos.ToString();

            // Verificar si el árbol es binario lleno
            bool esLleno = miArbol.EsArbolLleno(miRaiz);
            lblArbolLleno.Text = (esLleno ? "Sí" : "No");

            // Verificar si el árbol es completo
            bool esCompleto = miArbol.EsCompleto(miRaiz);
            lblArbolCompleto.Text = esCompleto ? "Sí" : "No";

            //Mostrar el recorrido por niveles
            lblRecorridoNiveles.Text = miArbol.RecorridoPorNiveles(miRaiz);
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor))
            {
                miRaiz = miArbol.RegresaRaiz();
                bool encontrado = miArbol.Busqueda(valor, miRaiz);

                if (encontrado)
                {
                    MessageBox.Show($"El valor {valor} sí se encuentra en el árbol");
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encuentra en el árbol");
                }

                txtDato.Text = ""; 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnEliminarPredecesor_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor))
            {
                miRaiz = miArbol.RegresaRaiz();
                miArbol.EliminarPredecesor(valor, ref miRaiz);

                // Actualiza la visualización del árbol en el formulario
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnEliminarSucesor_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor))
            {
                miRaiz = miArbol.RegresaRaiz();
                miArbol.EliminarSucesor(valor, ref miRaiz);

                // Actualiza la visualización del árbol en el formulario
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblArbolLleno_Click(object sender, EventArgs e)
        {

        }
    }
}
