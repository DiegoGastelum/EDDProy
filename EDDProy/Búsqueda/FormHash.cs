using System;
using System.Diagnostics; 
using System.IO;
using System.Windows.Forms;

namespace BusquedaHash
{
    public partial class FormHash : Form
    {
        private HashTable tablaHash;

        public FormHash()
        {
            InitializeComponent();
            tablaHash = new HashTable();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtClave.Text, out int claveBuscada))
            {
                // Inicia el temporizador
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int indiceHash;
                string resultado = tablaHash.Buscar(claveBuscada, out indiceHash);

                stopwatch.Stop();

                // Mostrar el tiempo transcurrido
                lbltime.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";

                // Mostrar el índice hash
                txtIndice.Text = indiceHash >= 0 ? indiceHash.ToString() : "No encontrado";

                // Mostrar el resultado de la búsqueda
                if (resultado != null)
                {
                    txtResultado.Text = $"{resultado}";
                }
                else
                {
                    txtResultado.Text = $"No encontrado.";
                }
            }
            else
            {
                MessageBox.Show("Introduce un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Ruta del archivo que contiene los datos a cargar en la tabla hash
            string rutaArchivo = "datos.txt";

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    // Separar clave y valor por coma
                    string[] partes = linea.Split(',');
                    if (partes.Length == 2 && int.TryParse(partes[0].Trim(), out int clave))
                    {
                        string valor = partes[1].Trim();
                        // Insertar la clave y el valor en la tabla hash
                        tablaHash.Insertar(clave, valor);
                    }
                }
            }
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void FormHash_Load(object sender, EventArgs e)
        {

        }
    }

    public class HashTable
    {
        private const int TAMANIO = 100;
        private int[] claves;           // Arreglo para almacenar las claves
        private string[] valores;       // Arreglo para almacenar los valores

        public HashTable()
        {
            claves = new int[TAMANIO];
            valores = new string[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                claves[i] = -1; // Inicializar todos los espacios como vacíos
            }
        }

        // Función hash avanzada para generar índices a partir de claves enteras
        private long FuncionHashAvanzada(uint clave, int tamanioTabla)
        {
            const int primo = 31;        // Número primo para mezclar los bits
            const uint mezclaBits = 0x9E3779B9; // Constante 
            uint hash = clave;

            // Mezclar los bits de la clave para mejorar la dispersión
            hash ^= (hash >> 16);       // Mezclar bits altos y bajos
            hash *= mezclaBits;         // Multiplicar por la constante 
            hash ^= (hash >> 13);       // Otra mezcla de bits
            hash *= primo;              // Multiplicar por un número primo
            hash ^= (hash >> 16);       // Mezcla final

            // Devolver el índice dentro del rango de la tabla
            return Math.Abs(hash) % tamanioTabla;
        }

        // Insertar una clave y un valor en la tabla hash
        public void Insertar(int clave, string valor)
        {
            uint clavePositiva = (uint)Math.Abs(clave); // Asegurar que la clave sea positiva
            int indice = (int)FuncionHashAvanzada(clavePositiva, TAMANIO);

            // Resolver colisiones usando linealidad
            while (claves[indice] != -1)
            {
                indice = (indice + 1) % TAMANIO;
            }

            // Almacenar la clave y el valor en el índice
            claves[indice] = clave;
            valores[indice] = valor;
        }

        // Buscar un valor asociado a una clave, devolviendo también el índice hash
        public string Buscar(int clave, out int indiceHash)
        {
            uint clavePositiva = (uint)Math.Abs(clave);
            int indice = (int)FuncionHashAvanzada(clavePositiva, TAMANIO);
            int inicio = indice;

            // Buscar la clave en la tabla hash
            while (claves[indice] != -1)
            {
                if (claves[indice] == clave)
                {
                    indiceHash = indice;
                    return valores[indice];
                }
                indice = (indice + 1) % TAMANIO;

                // Si volvemos al punto de inicio, la búsqueda termina
                if (indice == inicio)
                {
                    break;
                }
            }
            indiceHash = -1; 
            return null;
        }
    }
}
