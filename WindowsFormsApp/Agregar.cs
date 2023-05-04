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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp
{
    public partial class Agregar : Form
    {
        private Articulo articulo = null;
        private Imagen imagen = null;

        public Agregar()
        {
            InitializeComponent();
        }

        public Agregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar";
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
               
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                if (articulo!=null)
                {
                    tbCodigo.Text = articulo.Codigo;
                    tbNombre.Text = articulo.Nombre;
                    tbDescripcion.Text = articulo.Descripcion;
                    tbPrecio.Text = articulo.Precio.ToString();
                    tbImagen.Text=articulo.Imagen.ImagenUrl;
                    cargarImagen(articulo.Imagen.ImagenUrl);
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue= articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            //Imagen imagen = new Imagen();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                    imagen = new Imagen();
                }

                articulo.Codigo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                //imagen.IdArticulo = articulo.Id+1;
                //imagen.ImagenUrl = tbImagen.Text;

                if (articulo.Id != 0) 
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Se ha modificado correctamente");
                    Close();
                } 
                else 
                {
                    int idArt = articuloNegocio.agregar(articulo);
                    imagen.IdArticulo = idArt;
                    imagen.ImagenUrl = tbImagen.Text;
                    imagenNegocio.agregar(imagen);
                    MessageBox.Show("Se ha agregado correctamente");
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArt.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArt.Load("https://user-images.githubusercontent.com/43302778/106805462-7a908400-6645-11eb-958f-cd72b74a17b3.jpg");
            }
        }
    }
}
