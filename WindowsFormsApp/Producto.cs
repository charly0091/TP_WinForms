using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp
{
    public partial class Productos : Form

    {
        private List<Articulo> listaArticulo;
        public Productos()  
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Cargar();
            cbCampo.Items.Add("Código");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Precio");
        }

        private void Cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dgbArt.DataSource = listaArticulo;
                dgbArt.Columns["Id"].Visible = false;
                dgbArt.Columns["Imagen"].Visible = false;
                cargarImagen(listaArticulo[0].Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgbArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgbArt_SelectionChanged(object sender, EventArgs e)
        {
            if(dgbArt.CurrentRow!=null)
            {
                Articulo seleccionado = (Articulo)dgbArt.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen.ImagenUrl);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArt.Load(imagen);
            }
            catch (Exception ex) 
            {
                pbArt.Load("https://www.torninox.com/tnx_website/static/src/img/default.png");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.ShowDialog();

        }

        private void categoriasToolStripMenuItem_click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.ShowDialog();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nosotros nosotros = new Nosotros();
            nosotros.ShowDialog();

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      /*  private void btnVerDetalle_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            seleccionado = (Articulo)dgbArt.CurrentRow.DataBoundItem;

            Detalle verDetalle = new Detalle(seleccionado);
            verDetalle.ShowDialog();
        }*/

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaProductos alta = new AltaProductos();
            alta.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado=(Articulo)dgbArt.CurrentRow.DataBoundItem;

            AltaProductos modificar = new AltaProductos(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico =  false)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Articulo seleccionado;

            try
            {

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgbArt.CurrentRow.DataBoundItem;
                    int id = seleccionado.Id;
                    int idMarca = seleccionado.Marca.Id;

                    if (logico)
                    {
                        articuloNegocio.eliminarLogico(id, idMarca);
                    }
                    else
                    {
                        imagenNegocio.eliminar(id);
                        articuloNegocio.eliminar(id);
                    }
                        Cargar(); 
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

            List<Articulo> listaFiltrada;

            string filtro = tbBuscar.Text;

            if (filtro != " ")
            {
                listaFiltrada = listaArticulo.FindAll(articulo =>
                articulo.Nombre.ToUpper().Contains(filtro.ToUpper())
                );
                dgbArt.DataSource = null;
                dgbArt.DataSource = listaFiltrada;
                dgbArt.Columns["Id"].Visible = false;
                dgbArt.Columns["Imagen"].Visible = false;
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
        }

        private void pbArt_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            seleccionado = (Articulo)dgbArt.CurrentRow.DataBoundItem;

            Detalle verDetalle = new Detalle(seleccionado);
            verDetalle.ShowDialog();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cbCampo.SelectedItem.ToString();


            switch (campo)
            {
                case "Código":
                case "Nombre":
                case "Marca":
                case "Categoria":
                    cbCriterio.Items.Clear();
                    cbCriterio.Items.Add("Comienza con");
                    cbCriterio.Items.Add("Termina con");
                    cbCriterio.Items.Add("Contiene");
                    break;
                case "Precio":
                    cbCriterio.Items.Clear();
                    cbCriterio.Items.Add("A partir de");
                    cbCriterio.Items.Add("Hasta");
                    break;
            }
            
        }

        private bool validarFiltro()
        {
            if (cbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cbCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(tbFiltro.Text))
                {
                    MessageBox.Show("Por favor ingrese un precio para filtrar");
                    return true;
                }
                if (!(soloNumeros(tbFiltro.Text)))
                {
                    MessageBox.Show("Solo ingresar números");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = tbFiltro.Text;
                dgbArt.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void nosotrosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NosotrosEstatico NosotrosEstatico = new NosotrosEstatico();
            NosotrosEstatico.ShowDialog();
        }

    }
}
