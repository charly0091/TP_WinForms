using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.ShowDialog();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nosotros nosotros = new Nosotros();
            nosotros.ShowDialog();
        }

        private void nosotrosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NosotrosEstatico NosotrosEstatico = new NosotrosEstatico();
            NosotrosEstatico.ShowDialog();
        }
    }
}
