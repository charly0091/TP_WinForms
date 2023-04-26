using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace WindowsFormsApp
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void imgProd_Click(object sender, EventArgs e)
        {

        }

        private void dataProd_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio=new ArticuloNegocio();
            dataProd.DataSource = negocio.listar();
        }
    }
}
