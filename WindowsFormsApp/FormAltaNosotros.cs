using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp
{
    public partial class FormAltaNosotros : Form
    {
        public FormAltaNosotros()
        {
            InitializeComponent();
        }

        private void FormAltaNosotros_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Integrante integrante = new Integrante();
            IntegranteNegocio negocio = new IntegranteNegocio();
            try
            {
                integrante.Legajo=int.Parse(tbLegajo.Text);
                integrante.Nombre=tbNombre.Text;
                integrante.Apellido=tbApellido.Text;
                integrante.Avatar = tbAvatar.Text;

                negocio.agregar(integrante);
                MessageBox.Show("El integrante ha sido agregado");

                Close();
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
                pbIntegrante.Load(imagen);
            }
            catch (Exception ex)
            {
                pbIntegrante.Load("https://user-images.githubusercontent.com/43302778/106805462-7a908400-6645-11eb-958f-cd72b74a17b3.jpg");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAvatar_MouseLeave(object sender, EventArgs e)
        {
            cargarImagen(tbAvatar.Text);
        }
    }
}
