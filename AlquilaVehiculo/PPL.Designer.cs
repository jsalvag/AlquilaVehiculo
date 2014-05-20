namespace AlquilaVehiculo
{
    partial class PPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_actividad = new System.Windows.Forms.Label();
            this.box_user = new System.Windows.Forms.TextBox();
            this.pan_regCli = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rFNac = new System.Windows.Forms.DateTimePicker();
            this.rSexGroup = new System.Windows.Forms.GroupBox();
            this.rFem = new System.Windows.Forms.RadioButton();
            this.rMasc = new System.Windows.Forms.RadioButton();
            this.rFIng = new System.Windows.Forms.DateTimePicker();
            this.rTelf = new System.Windows.Forms.TextBox();
            this.rDir = new System.Windows.Forms.TextBox();
            this.rApe = new System.Windows.Forms.TextBox();
            this.rNom = new System.Windows.Forms.TextBox();
            this.rCI = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.m_registro = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pan_regCli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rSexGroup.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_actividad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 31);
            this.panel1.TabIndex = 2;
            // 
            // lb_actividad
            // 
            this.lb_actividad.AutoSize = true;
            this.lb_actividad.Location = new System.Drawing.Point(12, 5);
            this.lb_actividad.Name = "lb_actividad";
            this.lb_actividad.Size = new System.Drawing.Size(51, 20);
            this.lb_actividad.TabIndex = 3;
            this.lb_actividad.Text = "label2";
            // 
            // box_user
            // 
            this.box_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_user.Enabled = false;
            this.box_user.Location = new System.Drawing.Point(595, 3);
            this.box_user.Name = "box_user";
            this.box_user.Size = new System.Drawing.Size(177, 19);
            this.box_user.TabIndex = 2;
            // 
            // pan_regCli
            // 
            this.pan_regCli.Controls.Add(this.groupBox1);
            this.pan_regCli.Controls.Add(this.rSexGroup);
            this.pan_regCli.Controls.Add(this.rFIng);
            this.pan_regCli.Controls.Add(this.rTelf);
            this.pan_regCli.Controls.Add(this.rDir);
            this.pan_regCli.Controls.Add(this.rApe);
            this.pan_regCli.Controls.Add(this.rNom);
            this.pan_regCli.Controls.Add(this.rCI);
            this.pan_regCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_regCli.Location = new System.Drawing.Point(0, 56);
            this.pan_regCli.Name = "pan_regCli";
            this.pan_regCli.Size = new System.Drawing.Size(784, 351);
            this.pan_regCli.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.rFNac);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de Nacimiento";
            // 
            // rFNac
            // 
            this.rFNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rFNac.Location = new System.Drawing.Point(6, 17);
            this.rFNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.rFNac.Name = "rFNac";
            this.rFNac.Size = new System.Drawing.Size(198, 26);
            this.rFNac.TabIndex = 0;
            // 
            // rSexGroup
            // 
            this.rSexGroup.BackColor = System.Drawing.SystemColors.Window;
            this.rSexGroup.Controls.Add(this.rFem);
            this.rSexGroup.Controls.Add(this.rMasc);
            this.rSexGroup.Location = new System.Drawing.Point(12, 102);
            this.rSexGroup.Name = "rSexGroup";
            this.rSexGroup.Size = new System.Drawing.Size(210, 40);
            this.rSexGroup.TabIndex = 4;
            this.rSexGroup.TabStop = false;
            this.rSexGroup.Text = "Sexo";
            // 
            // rFem
            // 
            this.rFem.AutoSize = true;
            this.rFem.BackColor = System.Drawing.Color.Transparent;
            this.rFem.Location = new System.Drawing.Point(110, 16);
            this.rFem.Name = "rFem";
            this.rFem.Size = new System.Drawing.Size(98, 24);
            this.rFem.TabIndex = 1;
            this.rFem.TabStop = true;
            this.rFem.Text = "Femenino";
            this.rFem.UseVisualStyleBackColor = false;
            // 
            // rMasc
            // 
            this.rMasc.AutoSize = true;
            this.rMasc.BackColor = System.Drawing.Color.Transparent;
            this.rMasc.Location = new System.Drawing.Point(6, 16);
            this.rMasc.Name = "rMasc";
            this.rMasc.Size = new System.Drawing.Size(98, 24);
            this.rMasc.TabIndex = 0;
            this.rMasc.TabStop = true;
            this.rMasc.Text = "Masculino";
            this.rMasc.UseVisualStyleBackColor = false;
            // 
            // rFIng
            // 
            this.rFIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rFIng.Location = new System.Drawing.Point(228, 1);
            this.rFIng.Name = "rFIng";
            this.rFIng.Size = new System.Drawing.Size(208, 26);
            this.rFIng.TabIndex = 100;
            // 
            // rTelf
            // 
            this.rTelf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTelf.Location = new System.Drawing.Point(12, 279);
            this.rTelf.Name = "rTelf";
            this.rTelf.Size = new System.Drawing.Size(208, 19);
            this.rTelf.TabIndex = 7;
            this.rTelf.Text = "Teléfono";
            // 
            // rDir
            // 
            this.rDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rDir.Location = new System.Drawing.Point(12, 203);
            this.rDir.Multiline = true;
            this.rDir.Name = "rDir";
            this.rDir.Size = new System.Drawing.Size(208, 70);
            this.rDir.TabIndex = 6;
            this.rDir.Text = "Dirección";
            // 
            // rApe
            // 
            this.rApe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rApe.Location = new System.Drawing.Point(12, 70);
            this.rApe.Name = "rApe";
            this.rApe.Size = new System.Drawing.Size(210, 19);
            this.rApe.TabIndex = 3;
            this.rApe.Text = "Apellido";
            // 
            // rNom
            // 
            this.rNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rNom.Location = new System.Drawing.Point(12, 38);
            this.rNom.Name = "rNom";
            this.rNom.Size = new System.Drawing.Size(210, 19);
            this.rNom.TabIndex = 2;
            this.rNom.Text = "Nombre";
            // 
            // rCI
            // 
            this.rCI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rCI.Location = new System.Drawing.Point(12, 6);
            this.rCI.Name = "rCI";
            this.rCI.Size = new System.Drawing.Size(210, 19);
            this.rCI.TabIndex = 1;
            this.rCI.Text = "Cédula";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.m_registro});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(784, 25);
            this.menu.TabIndex = 4;
            this.menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_salir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // sm_salir
            // 
            this.sm_salir.Image = ((System.Drawing.Image)(resources.GetObject("sm_salir.Image")));
            this.sm_salir.Name = "sm_salir";
            this.sm_salir.Size = new System.Drawing.Size(96, 22);
            this.sm_salir.Text = "Salir";
            this.sm_salir.Click += new System.EventHandler(this.sm_salir_Click);
            // 
            // m_registro
            // 
            this.m_registro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_cliente});
            this.m_registro.Name = "m_registro";
            this.m_registro.Size = new System.Drawing.Size(62, 19);
            this.m_registro.Text = "Registro";
            // 
            // sm_cliente
            // 
            this.sm_cliente.Name = "sm_cliente";
            this.sm_cliente.Size = new System.Drawing.Size(152, 22);
            this.sm_cliente.Text = "Cliente";
            // 
            // PPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pan_regCli);
            this.Controls.Add(this.box_user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PPL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Alquiler de Vehículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPL_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pan_regCli.ResumeLayout(false);
            this.pan_regCli.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.rSexGroup.ResumeLayout(false);
            this.rSexGroup.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox box_user;
        private System.Windows.Forms.Panel pan_regCli;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sm_salir;
        private System.Windows.Forms.ToolStripMenuItem m_registro;
        private System.Windows.Forms.ToolStripMenuItem sm_cliente;
        private System.Windows.Forms.Label lb_actividad;
        private System.Windows.Forms.GroupBox rSexGroup;
        private System.Windows.Forms.RadioButton rFem;
        private System.Windows.Forms.RadioButton rMasc;
        private System.Windows.Forms.DateTimePicker rFIng;
        private System.Windows.Forms.DateTimePicker rFNac;
        private System.Windows.Forms.TextBox rTelf;
        private System.Windows.Forms.TextBox rDir;
        private System.Windows.Forms.TextBox rApe;
        private System.Windows.Forms.TextBox rNom;
        private System.Windows.Forms.TextBox rCI;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}