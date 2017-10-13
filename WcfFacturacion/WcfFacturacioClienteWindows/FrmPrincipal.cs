using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfFacturacioClienteWindows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos f = new FrmPedidos();
            f.MdiParent = this;
            f.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProducto f = new frmConsultaProducto();
            f.MdiParent = this;
            f.Show();
        }
    }
}
