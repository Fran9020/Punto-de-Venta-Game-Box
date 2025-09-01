namespace Punto_de_Venta_Game_Box
{
    partial class InicioVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LProducto = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.TbProducto = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.LCliente = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(120, 59);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(61, 16);
            this.LProducto.TabIndex = 0;
            this.LProducto.Text = "Producto";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(308, 59);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(38, 16);
            this.LTotal.TabIndex = 1;
            this.LTotal.Text = "Total";
            // 
            // TbProducto
            // 
            this.TbProducto.Location = new System.Drawing.Point(187, 56);
            this.TbProducto.Name = "TbProducto";
            this.TbProducto.Size = new System.Drawing.Size(100, 22);
            this.TbProducto.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Location = new System.Drawing.Point(491, 59);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(41, 16);
            this.LStock.TabIndex = 4;
            this.LStock.Text = "Stock";
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Location = new System.Drawing.Point(133, 126);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(48, 16);
            this.LCliente.TabIndex = 5;
            this.LCliente.Text = "Cliente";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.PrecioUni,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(123, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // PrecioUni
            // 
            this.PrecioUni.HeaderText = "Precio Unitario";
            this.PrecioUni.MinimumWidth = 6;
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 176);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(553, 100);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // InicioVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 658);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TbProducto);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.LProducto);
            this.Name = "InicioVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TbProducto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}