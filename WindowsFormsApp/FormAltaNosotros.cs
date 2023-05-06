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
using System.Configuration;
using System.IO;

namespace WindowsFormsApp
{
    public partial class FormAltaNosotros : Form
    {
        /*private Integrante integrante = null;
        OpenFileDialog archivo = new OpenFileDialog();
        public FormAltaNosotros()
        {
            InitializeComponent();
        }
        public FormAltaNosotros(Integrante modificar)
        {
            InitializeComponent();
            this.integrante = modificar;
        }

        private void FormAltaNosotros_Load(object sender, EventArgs e)
        {
            try
            {
                if(integrante != null)
                {
                    tbLegajo.Text=integrante.Legajo.ToString();
                    tbNombre.Text= integrante.Nombre;
                    tbApellido.Text=integrante.Apellido;
                    tbAvatar.Text=integrante.Avatar;
                    cargarImagen(integrante.Avatar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Integrante integrante = new Integrante();
            IntegranteNegocio negocio = new IntegranteNegocio();
            try
            {
                if(integrante==null)
                {
                    integrante = new Integrante();
                }
                integrante.Legajo=int.Parse(tbLegajo.Text);
                integrante.Nombre=tbNombre.Text;
                integrante.Apellido=tbApellido.Text;
                integrante.Avatar = tbAvatar.Text;

                if(integrante.Id!=0)
                {
                    negocio.modificar(integrante);
                    MessageBox.Show("El integrante ha sido modificado");
                } 
                else
                {
                    negocio.agregar(integrante);
                    MessageBox.Show("El integrante ha sido agregado");
                }

                if (archivo != null && !(tbAvatar.Text.ToLower().Contains("http")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images"] + archivo.SafeFileName);
                }

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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                archivo.Filter = "jpg|*.jpg; |png|*.png";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    tbAvatar.Text = archivo.FileName;
                    cargarImagen(archivo.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/
    }
}
