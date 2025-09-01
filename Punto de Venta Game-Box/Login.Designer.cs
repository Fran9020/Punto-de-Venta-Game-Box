namespace Punto_de_Venta_Game_Box
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContraseña = new System.Windows.Forms.Label();
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.TbContraseña = new System.Windows.Forms.TextBox();
            this.BIngresar = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(133, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(300, 113);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(57, 16);
            this.LUsuario.TabIndex = 1;
            this.LUsuario.Text = "Usuario:";
            this.LUsuario.Click += new System.EventHandler(this.LUsuario_Click);
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Location = new System.Drawing.Point(300, 182);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(76, 16);
            this.LContraseña.TabIndex = 2;
            this.LContraseña.Text = "Contraseña";
            this.LContraseña.Click += new System.EventHandler(this.LContraseña_Click);
            // 
            // TbUsuario
            // 
            this.TbUsuario.Location = new System.Drawing.Point(303, 132);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(100, 22);
            this.TbUsuario.TabIndex = 3;
            // 
            // TbContraseña
            // 
            this.TbContraseña.Location = new System.Drawing.Point(303, 201);
            this.TbContraseña.Name = "TbContraseña";
            this.TbContraseña.Size = new System.Drawing.Size(100, 22);
            this.TbContraseña.TabIndex = 4;
            this.TbContraseña.TextChanged += new System.EventHandler(this.TbContraseña_TextChanged);
            // 
            // BIngresar
            // 
            this.BIngresar.Location = new System.Drawing.Point(303, 256);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(75, 23);
            this.BIngresar.TabIndex = 5;
            this.BIngresar.Text = "Ingresar";
            this.BIngresar.UseVisualStyleBackColor = true;
            // 
            // BCerrar
            // 
            this.BCerrar.Location = new System.Drawing.Point(402, 256);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(75, 23);
            this.BCerrar.TabIndex = 6;
            this.BCerrar.Text = "Salir";
            this.BCerrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.BIngresar);
            this.Controls.Add(this.TbContraseña);
            this.Controls.Add(this.TbUsuario);
            this.Controls.Add(this.LContraseña);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.TextBox TbUsuario;
        private System.Windows.Forms.TextBox TbContraseña;
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.Button BCerrar;
    }
}

