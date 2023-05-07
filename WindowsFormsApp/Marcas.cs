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
    public partial class Marcas : Form
    { 

        private List<Marca> listaMarca;
        
        public Marcas()
        {
            InitializeComponent();
        }


        private void Marcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaMarcas alta = new AltaMarcas();
            alta.ShowDialog();
            cargar();

        }


        private void cargar() 
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarca = negocio.listar();
            dgvMarcas.DataSource = listaMarca;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            AltaMarcas modificar = new AltaMarcas(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirmas la eliminación?", "Eliminando",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
