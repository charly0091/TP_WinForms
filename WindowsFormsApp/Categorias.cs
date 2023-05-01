using dominio;
using negocio;
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
    public partial class Categorias : Form
    {

        private List<Categoria> listaCategoria;

        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategoria = negocio.listar();
            dgvCategorias.DataSource = listaCategoria;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
