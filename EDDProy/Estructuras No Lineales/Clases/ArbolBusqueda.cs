using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            return Raiz == null;
        }

        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public bool Busqueda(int Valor, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == Valor)
                return true;
            else if (Valor < nodo.Dato)
                return Busqueda(Valor, nodo.Izq);
            else
                return Busqueda(Valor, nodo.Der);
        }

        public bool InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            // Verifica si el valor ya existe
            if (Busqueda(Dato, Raiz))
            {
                return false; // El valor ya existe en el árbol
            }

            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                if (Raiz == null)
                    Raiz = Nodo;
                return true; // Nodo insertado 
            }
            else if (Dato < Nodo.Dato)
            {
                return InsertaNodo(Dato, ref Nodo.Izq);
            }
            else if (Dato > Nodo.Dato)
            {
                return InsertaNodo(Dato, ref Nodo.Der);
            }

            return false; // No se insertó
        }

        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol += "      ";
            }
            strArbol += nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido += nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido += nodo.Dato + ", ";
            InOrden(nodo.Der);
        }

        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido += nodo.Dato + ", ";
        }
        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            // Llama recursivamente para podar el subárbol izquierdo y derecho
            PodarArbol(ref nodo.Izq);
            PodarArbol(ref nodo.Der);

            // Elimina el nodo actual
            nodo = null;
        }
        public void EliminarPredecesor(int valor, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (valor < nodo.Dato)
            {
                EliminarPredecesor(valor, ref nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                EliminarPredecesor(valor, ref nodo.Der);
            }
            else
            {
                // Caso en que el nodo tiene dos hijos
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario predecesor = BuscaMayor(nodo.Izq);
                    nodo.Dato = predecesor.Dato;
                    EliminarPredecesor(predecesor.Dato, ref nodo.Izq);
                }
                else
                {
                    // Caso en que el nodo tiene un hijo o ninguno
                    NodoBinario temp = nodo;
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;

                    // Elimina el nodo
                    temp = null;
                }
            }
        }

        private NodoBinario BuscaMayor(NodoBinario nodo)
        {
            while (nodo.Der != null)
                nodo = nodo.Der;
            return nodo;
        }
        public void EliminarSucesor(int valor, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (valor < nodo.Dato)
            {
                EliminarSucesor(valor, ref nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                EliminarSucesor(valor, ref nodo.Der);
            }
            else
            {
                // Caso en que el nodo tiene dos hijos
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario sucesor = BuscaMenor(nodo.Der);
                    nodo.Dato = sucesor.Dato;
                    EliminarSucesor(sucesor.Dato, ref nodo.Der);
                }
                else
                {
                    // Caso en que el nodo tiene un hijo o ninguno
                    NodoBinario temp = nodo;
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;

                    // Elimina el nodo
                    temp = null;
                }
            }
        }

        private NodoBinario BuscaMenor(NodoBinario nodo)
        {
            while (nodo.Izq != null)
                nodo = nodo.Izq;
            return nodo;
        }
        public int ObtenerAltura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;  // La altura de un nodo nulo es 0

            // Obtener la altura de los subárboles izquierdo y derecho
            int alturaIzquierda = ObtenerAltura(nodo.Izq);
            int alturaDerecha = ObtenerAltura(nodo.Der);

            // La altura del árbol es 1 + la altura máxima de los subárboles
            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }
        public int ContarHojas(NodoBinario nodo)
        {
            // Si el nodo es nulo, no hay hoja
            if (nodo == null)
                return 0;

            // Si el nodo no tiene hijos, es una hoja
            if (nodo.Izq == null && nodo.Der == null)
                return 1;

            // Si el nodo tiene hijos, contar las hojas en los subárboles izquierdo y derecho
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }
        public int ContarNodos(NodoBinario nodo)
        {
            // Si el nodo es nulo, no hay nodos
            if (nodo == null)
                return 0;

            // El nodo actual cuenta como uno, luego contamos los nodos de los subárboles
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }
        public bool EsArbolLleno(NodoBinario nodo)
        {
            // si el nodo es nulo, se considera lleno
            if (nodo == null)
                return true;

            // Si el nodo tiene ambos hijos, se verifica recursivamente en los dos subárboles
            if (nodo.Izq != null && nodo.Der != null)
                return EsArbolLleno(nodo.Izq) && EsArbolLleno(nodo.Der);

            // Si el nodo es una hoja, también se considera lleno
            if (nodo.Izq == null && nodo.Der == null)
                return true;

            // Si el nodo tiene solo un hijo, no es un árbol binario lleno
            return false;
        }
        public bool EsCompleto(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return true; // Un árbol vacío es completo

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(nodoPtr);
            bool nodoLleno = false;

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();

                // Verifica el nodo izquierdo
                if (nodoAuxiliar.Izq != null)
                {
                    // Si se encontró un nodo sin hijo izquierdo o derecho antes, no es completo
                    if (nodoLleno)
                        return false;

                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                }
                else
                {
                    nodoLleno = true; // Marca que se encontró un nodo incompleto
                }

                // Verifica el nodo derecho
                if (nodoAuxiliar.Der != null)
                {
                    if (nodoLleno)
                        return false;

                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
                }
                else
                {
                    nodoLleno = true;
                }
            }

            return true;
        }
        public string RecorridoPorNiveles(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return "El árbol está vacío.";

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodoPtr);
            StringBuilder resultado = new StringBuilder();

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();
                resultado.Append(nodoActual.Dato + " "); // Agrega el valor del nodo al resultado

                // Encola el hijo izquierdo
                if (nodoActual.Izq != null)
                {
                    cola.Enqueue(nodoActual.Izq);
                }

                // Encola el hijo derecho
                if (nodoActual.Der != null)
                {
                    cola.Enqueue(nodoActual.Der);
                }
            }

            return resultado.ToString().Trim();
        }

    }
}
