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
    public partial class FrmPedidos : Form
    {

        ServiceFacturacionClient sfc = new ServiceFacturacionClient();


        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            cmCliente.DataSource = sfc.GetClientes();
            cmCliente.DisplayMember = "Nombres";
            cmCliente.ValueMember = "IDCliente";
            cmCliente.SelectedIndex = -1;

            cmProducto.DataSource = sfc.GetProductos();
            cmProducto.DisplayMember = "Descripcion";
            cmProducto.ValueMember = "IDProducto";
            cmProducto.SelectedIndex = -1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmCliente.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                cmCliente.Focus();
                return;
            }

            if (cmProducto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                cmProducto.Focus();
                return;
            }
            if (txtCantidad.Text == "")
            {
               
                MessageBox.Show("Debe ingresar una cantidad");
                txtCantidad.Focus();
                return;
            }

            int cantidad;
            try
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
            }
            catch
            {
                cantidad = 0;

            }

            if(cantidad<=0)
            {
                MessageBox.Show("Debe ingresar una cantidad valida");
                txtCantidad.Focus();
                return;
            }
            sfc.NewPedido(DateTime.Now, cmCliente.SelectedValue.ToString(), 
              Convert.ToInt32(cmProducto.SelectedValue), txtNota.Text, false, cantidad);
            MessageBox.Show("Pedido adicionado con Exito!!");
            cmCliente.SelectedIndex = -1;
            cmProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtNota.Text = "";
        }
    }
}
