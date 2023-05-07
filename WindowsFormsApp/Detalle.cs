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
    public partial class Detalle : Form
    {

        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public Detalle()
        {
            InitializeComponent();
        }

        public Detalle(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            Text = "Ver Detalle";
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            lblArtNombre.Text = articulo.Nombre;
            lblArtDescripcion.Text = "Descripción: " + articulo.Descripcion;
            lblArtMarca.Text = "Marca: " + articulo.Marca.Descripcion;
            lblArtCategoria.Text = "Categoria: " + articulo.Categoria.Descripcion;
            lblArtPrecio.Text = "Precio: $" + articulo.Precio.ToString();
            cargarImagen(articulo.Imagen.ImagenUrl);
            lblArtCodigo.Text = "Codigo: " + articulo.Codigo;
            lblArtId.Text = "ID: " + articulo.Id.ToString();

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArt.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArt.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

    }
}
