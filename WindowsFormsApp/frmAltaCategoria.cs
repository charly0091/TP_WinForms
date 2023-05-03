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
    public partial class frmAltaCategoria : Form
    {
        

        public frmAltaCategoria()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            int autoId;
            CategoriaNegocio negocio = new CategoriaNegocio();
            autoId = negocio.numeroId();
            lblAutoId.Text = autoId.ToString();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria categ = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categ.Id = negocio.numeroId();
                categ.Descripcion = txtDescripcion.Text;

                negocio.agregar(categ);
                MessageBox.Show("Agregado Correctamente");
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
