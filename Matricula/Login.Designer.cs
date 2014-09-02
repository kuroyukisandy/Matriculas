namespace Matricula
{
    partial class F_matricula
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.TB_clave = new System.Windows.Forms.TextBox();
            this.L_usuario = new System.Windows.Forms.Label();
            this.L_contraseña = new System.Windows.Forms.Label();
            this.B_ingresar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_usuario
            // 
            this.TB_usuario.Location = new System.Drawing.Point(54, 32);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(177, 20);
            this.TB_usuario.TabIndex = 0;
            // 
            // TB_clave
            // 
            this.TB_clave.Location = new System.Drawing.Point(54, 75);
            this.TB_clave.Name = "TB_clave";
            this.TB_clave.PasswordChar = '*';
            this.TB_clave.Size = new System.Drawing.Size(177, 20);
            this.TB_clave.TabIndex = 1;
            this.TB_clave.UseSystemPasswordChar = true;
            // 
            // L_usuario
            // 
            this.L_usuario.AutoSize = true;
            this.L_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_usuario.Location = new System.Drawing.Point(117, 13);
            this.L_usuario.Name = "L_usuario";
            this.L_usuario.Size = new System.Drawing.Size(54, 13);
            this.L_usuario.TabIndex = 2;
            this.L_usuario.Text = "Usuario:";
            // 
            // L_contraseña
            // 
            this.L_contraseña.AutoSize = true;
            this.L_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_contraseña.Location = new System.Drawing.Point(120, 59);
            this.L_contraseña.Name = "L_contraseña";
            this.L_contraseña.Size = new System.Drawing.Size(43, 13);
            this.L_contraseña.TabIndex = 3;
            this.L_contraseña.Text = "Clave:";
            // 
            // B_ingresar
            // 
            this.B_ingresar.Location = new System.Drawing.Point(54, 104);
            this.B_ingresar.Name = "B_ingresar";
            this.B_ingresar.Size = new System.Drawing.Size(65, 26);
            this.B_ingresar.TabIndex = 4;
            this.B_ingresar.Text = "Ingresar";
            this.B_ingresar.UseVisualStyleBackColor = true;
            this.B_ingresar.Click += new System.EventHandler(this.B_ingresar_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(156, 107);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_Cancelar.TabIndex = 5;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // F_matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 142);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_ingresar);
            this.Controls.Add(this.L_contraseña);
            this.Controls.Add(this.L_usuario);
            this.Controls.Add(this.TB_clave);
            this.Controls.Add(this.TB_usuario);
            this.Name = "F_matricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrículas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_usuario;
        private System.Windows.Forms.TextBox TB_clave;
        private System.Windows.Forms.Label L_usuario;
        private System.Windows.Forms.Label L_contraseña;
        private System.Windows.Forms.Button B_ingresar;
        private System.Windows.Forms.Button B_Cancelar;
    }
}

