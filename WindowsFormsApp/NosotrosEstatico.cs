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

namespace WindowsFormsApp
{
    public partial class NosotrosEstatico : Form
    {
        public NosotrosEstatico()
        {
            InitializeComponent();
        }

        private void pbPinto_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/carlos-pinto-mdp/");
        }

        private void pbScaglione_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/franco-scaglione-62b3591b2/");
        }

        private void pbVisconti_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/mariaclaravisconti/");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.ShowDialog();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NosotrosEstatico NosotrosEstatico = new NosotrosEstatico();
            NosotrosEstatico.ShowDialog();
        }
    }
}
