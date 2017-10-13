using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfFacturacioClienteWindows.WcfFacturacion;

namespace WcfFacturacioClienteWindows
{
    public partial class frmConsultaProducto : Form
    {
        ServiceFacturacionClient sfc = new ServiceFacturacionClient();

        public frmConsultaProducto()
        {
            InitializeComponent();
        }

        private void FmrConsultaProductos_load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butonConsulta_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = sfc.GetProductos();

            if(textIdProducto.Text == "")
            {
                MessageBox.Show("Debe ingresar el Id de producto");
                textIdProducto.Focus();
                return;
            }

            Producto producto = sfc.GetProducto(Convert.ToInt32(textIdProducto.Text));
            
            if(producto == null)
            {
                MessageBox.Show("Producto no existe");
                textDescripcion.Text = "";
                textPrecio.Text = "";
                textStock.Text = "";
                textNotas.Text = "";
                textIdProducto.Focus();
                return;
            }

            textDescripcion.Text = producto.Descripcion;
            textPrecio.Text = producto.Precio.ToString();
            textStock.Text = producto.Stock.ToString();
            textNotas.Text = producto.Notas.ToString();

        }

        private void frmConsultaProducto_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = sfc.GetProductos();
        }
    }
}
