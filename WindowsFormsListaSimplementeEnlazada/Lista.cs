using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaSimplementeEnlazada
{
    internal class Lista
    {
        public Nodo primero;
        public Nodo ultimo;
        public Lista()
        {
            this.primero = null;
            this.ultimo = null;
        }
        public bool listavacia()
        {
            return this.primero == null ? true : false;
        }
        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = dato;
            nuevo.sig = null;
            if (this.listavacia())
            {
                this.primero = nuevo;
                this.ultimo = nuevo;
            }
            else
            {
                this.ultimo.sig = nuevo;
                this.ultimo = nuevo;

            }
        }
        public void Listar(ListBox lista)
        {
            lista.Items.Clear();
            if (this.listavacia())
            {
                MessageBox.Show("LA LISTA ESTA VACIA");

            }
            else
            {
                Nodo puntero = this.primero;
                while (puntero!=null)
                {
                    lista.Items.Add(puntero.info);
                    puntero = puntero.sig;
                }
            }
        }
    }
}
