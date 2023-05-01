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
            lblArtDescripcion.Text = articulo.Descripcion;
            lblArtMarca.Text = articulo.Marca.Descripcion;
            lblArtCategoria.Text = articulo.Categoria.Descripcion;
            lblArtPrecio.Text = articulo.Precio.ToString();
            pbArt.Load(articulo.Imagen.ImagenUrl);
            lblArtCodigo.Text = articulo.Codigo;
            lblArtId.Text = articulo.Id.ToString();

        }

    }
}
