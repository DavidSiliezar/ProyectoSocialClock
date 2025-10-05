namespace Vistas.Formularios
{
    partial class frmPrimerUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimerUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.pnlPrimerUsuario = new System.Windows.Forms.Panel();
            this.btnRegistrar = new Vistas.Clases.RedondearBoton();
            this.txtClaveRegistrar = new System.Windows.Forms.TextBox();
            this.txtCorreoRegistrar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlPrimerUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.lblBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Location = new System.Drawing.Point(203, 23);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(644, 56);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido a Social Clock  ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(68, 23);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(448, 37);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Ingrese su correo electronico:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(129, 159);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(308, 37);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Cree su contraseña:";
            // 
            // pnlPrimerUsuario
            // 
            this.pnlPrimerUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnlPrimerUsuario.Controls.Add(this.btnRegistrar);
            this.pnlPrimerUsuario.Controls.Add(this.txtClaveRegistrar);
            this.pnlPrimerUsuario.Controls.Add(this.txtCorreoRegistrar);
            this.pnlPrimerUsuario.Controls.Add(this.pictureBox2);
            this.pnlPrimerUsuario.Controls.Add(this.pictureBox1);
            this.pnlPrimerUsuario.Controls.Add(this.lblCorreo);
            this.pnlPrimerUsuario.Controls.Add(this.lblClave);
            this.pnlPrimerUsuario.Location = new System.Drawing.Point(237, 166);
            this.pnlPrimerUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrimerUsuario.Name = "pnlPrimerUsuario";
            this.pnlPrimerUsuario.Size = new System.Drawing.Size(553, 389);
            this.pnlPrimerUsuario.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnRegistrar.BorderRadius = 30;
            this.btnRegistrar.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(157, 306);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(241, 57);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // txtClaveRegistrar
            // 
            this.txtClaveRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveRegistrar.Location = new System.Drawing.Point(183, 228);
            this.txtClaveRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClaveRegistrar.Multiline = true;
            this.txtClaveRegistrar.Name = "txtClaveRegistrar";
            this.txtClaveRegistrar.PasswordChar = '*';
            this.txtClaveRegistrar.Size = new System.Drawing.Size(234, 25);
            this.txtClaveRegistrar.TabIndex = 9;
            this.txtClaveRegistrar.WordWrap = false;
            this.txtClaveRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveRegistrar_KeyPress_1);
            // 
            // txtCorreoRegistrar
            // 
            this.txtCorreoRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoRegistrar.Location = new System.Drawing.Point(183, 91);
            this.txtCorreoRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoRegistrar.Multiline = true;
            this.txtCorreoRegistrar.Name = "txtCorreoRegistrar";
            this.txtCorreoRegistrar.Size = new System.Drawing.Size(234, 25);
            this.txtCorreoRegistrar.TabIndex = 8;
            this.txtCorreoRegistrar.WordWrap = false;
            this.txtCorreoRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoRegistrar_KeyPress_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_21_195419;
            this.pictureBox2.Location = new System.Drawing.Point(136, 216);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 63);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_21_195352;
            this.pictureBox1.Location = new System.Drawing.Point(136, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrimerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondodos;
            this.ClientSize = new System.Drawing.Size(1030, 610);
            this.Controls.Add(this.pnlPrimerUsuario);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1048, 657);
            this.MinimumSize = new System.Drawing.Size(1048, 657);
            this.Name = "frmPrimerUsuario";
            this.Text = "Primer Usuario";
            this.Load += new System.EventHandler(this.frmPrimerUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPrimerUsuario.ResumeLayout(false);
            this.pnlPrimerUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel pnlPrimerUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCorreoRegistrar;
        private System.Windows.Forms.TextBox txtClaveRegistrar;
        private Clases.RedondearBoton btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}