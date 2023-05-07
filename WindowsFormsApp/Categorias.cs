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
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategoria = negocio.listar();
            dgvCategorias.DataSource = listaCategoria;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaCategorias alta = new AltaCategorias();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            AltaCategorias modificar = new AltaCategorias(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirmas la eliminación?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void eliminaciones() 
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;


            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
        }

    }
}
