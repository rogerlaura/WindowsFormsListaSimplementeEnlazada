using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaSimplementeEnlazada
{
    public partial class Form1 : Form
    {
        Lista lista;
        public Form1()
        {
            lista = new Lista();
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (txtdato.Text != "")
            {
                int dato = int.Parse(txtdato.Text);
                lista.Insertar(dato);
                lista.Listar(listadatos);
            }
            else
            {
                MessageBox.Show("Digite un valor en la caja de texto");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
