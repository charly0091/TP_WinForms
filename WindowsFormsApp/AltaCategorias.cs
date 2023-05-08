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
    public partial class AltaCategorias : Form
    {
        private Categoria categoria = null;

        public AltaCategorias()
        {
            InitializeComponent();
        }



        public AltaCategorias(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            int autoId;
            CategoriaNegocio negocio = new CategoriaNegocio();


            if (this.categoria != null)
            {
                this.Text = "Modificar Categoria";
                autoId = negocio.numeroIdModificar(categoria);
                lblAutoId.Text = autoId.ToString();
                txtDescripcion.Text = this.categoria.Descripcion;
            }
            else 
            {
                autoId = negocio.UltimoId()+1;
                lblAutoId.Text = autoId.ToString();
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if(categoria == null) 
                {
                    categoria = new Categoria();
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese una descripción válida.");
                    return;
                }

                categoria.Id = negocio.numeroIdModificar(this.categoria);
               categoria.Descripcion = txtDescripcion.Text;

                if(categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Modificado Correctamente");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Agregado Correctamente");
                }

                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
