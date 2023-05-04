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
    public partial class Nosotros : Form
    {
        private List<Integrante> listaNosotros;
        public Nosotros()
        {
            InitializeComponent();
        }
        private void Nosotros_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                IntegranteNegocio negocio = new IntegranteNegocio();
                listaNosotros = negocio.Listar();
                dgbNosotros.DataSource = listaNosotros;
                dgbNosotros.Columns["Id"].Visible = false;
                dgbNosotros.Columns["Avatar"].Visible = false;
                cargarImagen(listaNosotros[0].Avatar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbNosotros.Load(imagen);
            }
            catch (Exception ex)
            {
                pbNosotros.Load("https://user-images.githubusercontent.com/43302778/106805462-7a908400-6645-11eb-958f-cd72b74a17b3.jpg");
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void dgbNosotros_SelectionChanged(object sender, EventArgs e)
        {
            Integrante seleccionado = (Integrante)dgbNosotros.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Avatar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaNosotros alta = new FormAltaNosotros();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Integrante seleccionado;
            seleccionado=(Integrante)dgbNosotros.CurrentRow.DataBoundItem;

            FormAltaNosotros modificar = new FormAltaNosotros(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
