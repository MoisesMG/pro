namespace WcfFacturacioClienteWindows
{
    partial class frmConsultaProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textIdProducto = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textNotas = new System.Windows.Forms.TextBox();
            this.butonConsulta = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdProducto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notas:";
            // 
            // textIdProducto
            // 
            this.textIdProducto.Location = new System.Drawing.Point(109, 33);
            this.textIdProducto.Name = "textIdProducto";
            this.textIdProducto.Size = new System.Drawing.Size(144, 20);
            this.textIdProducto.TabIndex = 5;
            this.textIdProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(109, 67);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(245, 20);
            this.textDescripcion.TabIndex = 6;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(109, 103);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(245, 20);
            this.textPrecio.TabIndex = 7;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(109, 139);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(100, 20);
            this.textStock.TabIndex = 8;
            // 
            // textNotas
            // 
            this.textNotas.Location = new System.Drawing.Point(109, 172);
            this.textNotas.Multiline = true;
            this.textNotas.Name = "textNotas";
            this.textNotas.Size = new System.Drawing.Size(201, 88);
            this.textNotas.TabIndex = 9;
            // 
            // butonConsulta
            // 
            this.butonConsulta.Location = new System.Drawing.Point(268, 20);
            this.butonConsulta.Name = "butonConsulta";
            this.butonConsulta.Size = new System.Drawing.Size(86, 38);
            this.butonConsulta.TabIndex = 10;
            this.butonConsulta.Text = "&Consultar";
            this.butonConsulta.UseVisualStyleBackColor = true;
            this.butonConsulta.Click += new System.EventHandler(this.butonConsulta_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(109, 267);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(240, 150);
            this.dgvProductos.TabIndex = 11;
            // 
            // frmConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 368);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.butonConsulta);
            this.Controls.Add(this.textNotas);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textIdProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaProducto";
            this.Text = "ConsultaProducto";
            this.Load += new System.EventHandler(this.frmConsultaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIdProducto;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textNotas;
        private System.Windows.Forms.Button butonConsulta;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}

