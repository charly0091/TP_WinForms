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
    public partial class frmAltaMarca : Form
    {
        public frmAltaMarca()
        {
            InitializeComponent();
        }


        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            int autoId;
            MarcaNegocio negocio = new MarcaNegocio();
            autoId = negocio.numeroId();
            lblAutoId.Text = autoId.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marc = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marc.Id = negocio.numeroId();
                marc.Descripcion = txtDescripcion.Text;

                negocio.agregar(marc);
                MessageBox.Show("Agregado Correctamente");
                Close();
            }
            catch (Exception)
            {

                throw;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
