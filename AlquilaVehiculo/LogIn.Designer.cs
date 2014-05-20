namespace AlquilaVehiculo
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.logUser = new System.Windows.Forms.TextBox();
            this.logClave = new System.Windows.Forms.TextBox();
            this.logEntrar = new System.Windows.Forms.Button();
            this.logCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logUser
            // 
            this.logUser.Location = new System.Drawing.Point(19, 14);
            this.logUser.Name = "logUser";
            this.logUser.Size = new System.Drawing.Size(163, 26);
            this.logUser.TabIndex = 1;
            this.logUser.Text = "Usuario";
            this.logUser.Enter += new System.EventHandler(this._Enter);
            this.logUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // logClave
            // 
            this.logClave.Location = new System.Drawing.Point(19, 46);
            this.logClave.Name = "logClave";
            this.logClave.Size = new System.Drawing.Size(163, 26);
            this.logClave.TabIndex = 2;
            this.logClave.Text = "Clave";
            this.logClave.Enter += new System.EventHandler(this._Enter);
            this.logClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // logEntrar
            // 
            this.logEntrar.Location = new System.Drawing.Point(18, 78);
            this.logEntrar.Name = "logEntrar";
            this.logEntrar.Size = new System.Drawing.Size(82, 28);
            this.logEntrar.TabIndex = 3;
            this.logEntrar.Text = "Entrar";
            this.logEntrar.UseVisualStyleBackColor = true;
            this.logEntrar.Click += new System.EventHandler(this.etrar);
            // 
            // logCancelar
            // 
            this.logCancelar.Location = new System.Drawing.Point(100, 78);
            this.logCancelar.Name = "logCancelar";
            this.logCancelar.Size = new System.Drawing.Size(82, 28);
            this.logCancelar.TabIndex = 4;
            this.logCancelar.Text = "Cancelar";
            this.logCancelar.UseVisualStyleBackColor = true;
            this.logCancelar.Click += new System.EventHandler(this.cerrar);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(200, 120);
            this.Controls.Add(this.logCancelar);
            this.Controls.Add(this.logEntrar);
            this.Controls.Add(this.logClave);
            this.Controls.Add(this.logUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logUser;
        private System.Windows.Forms.TextBox logClave;
        private System.Windows.Forms.Button logEntrar;
        private System.Windows.Forms.Button logCancelar;
    }
}

