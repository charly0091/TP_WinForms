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
        private Marca marca = null;

        public frmAltaMarca()
        {
            InitializeComponent();
        }


        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }


        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            int autoId;
            MarcaNegocio negocio = new MarcaNegocio();

            if(this.marca != null) 
            {
                this.Text = "Modificar Marca";
                autoId = negocio.numeroIdModificar(marca);
                lblAutoId.Text = autoId.ToString();
                txtDescripcion.Text = this.marca.Descripcion;
            }
            else
            {
                autoId = negocio.numeroId();
                lblAutoId.Text = autoId.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if(marca == null) 
                {
                    marca = new Marca();
                }

                marca.Id = negocio.numeroIdModificar(this.marca);
                marca.Descripcion = txtDescripcion.Text;

                if (marca.Id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado Correctamente");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado Correctamente");
                }
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
