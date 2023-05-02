﻿using System;
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
    public partial class Productos : Form

    {
        private List<Articulo> listaArticulo;
        public Productos()  
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgbArt.DataSource = listaArticulo;
            dgbArt.Columns["Id"].Visible = false;
            dgbArt.Columns["Imagen"].Visible = false;
            cargarImagen(listaArticulo[0].Imagen.ImagenUrl);
        }

        private void dgbArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgbArt_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgbArt.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.ImagenUrl);
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

        private void btnVerDetalle_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            seleccionado = (Articulo)dgbArt.CurrentRow.DataBoundItem;

            Detalle verDetalle = new Detalle(seleccionado);
            verDetalle.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar alta = new Agregar();
            alta.ShowDialog();
        }
    }
}