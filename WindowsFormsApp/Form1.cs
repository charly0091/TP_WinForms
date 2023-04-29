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
    }
}
