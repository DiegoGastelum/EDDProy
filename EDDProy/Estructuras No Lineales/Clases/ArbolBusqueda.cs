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
    }
}
