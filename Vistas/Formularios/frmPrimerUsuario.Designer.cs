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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCorreoRegistrar = new System.Windows.Forms.TextBox();
            this.txtClaveRegistrar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new Vistas.Clases.RedondearBoton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.lblBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Image = global::Vistas.Properties.Resources.fondo;
            this.lblBienvenida.Location = new System.Drawing.Point(233, 22);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(509, 44);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido a Social Clock  ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(22, 19);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(369, 29);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Ingrese su correo electronico :";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(22, 147);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(253, 29);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Cree su contraseña :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.txtClaveRegistrar);
            this.panel2.Controls.Add(this.txtCorreoRegistrar);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblCorreo);
            this.panel2.Controls.Add(this.lblClave);
            this.panel2.Location = new System.Drawing.Point(268, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 316);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_21_195352;
            this.pictureBox1.Location = new System.Drawing.Point(67, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 63);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_21_195419;
            this.pictureBox2.Location = new System.Drawing.Point(62, 189);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 51);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txtCorreoRegistrar
            // 
            this.txtCorreoRegistrar.Location = new System.Drawing.Point(123, 76);
            this.txtCorreoRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoRegistrar.Name = "txtCorreoRegistrar";
            this.txtCorreoRegistrar.Size = new System.Drawing.Size(211, 20);
            this.txtCorreoRegistrar.TabIndex = 8;
            this.txtCorreoRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoRegistrar_KeyPress_1);
            // 
            // txtClaveRegistrar
            // 
            this.txtClaveRegistrar.Location = new System.Drawing.Point(123, 205);
            this.txtClaveRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveRegistrar.Name = "txtClaveRegistrar";
            this.txtClaveRegistrar.Size = new System.Drawing.Size(211, 20);
            this.txtClaveRegistrar.TabIndex = 9;
            this.txtClaveRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveRegistrar_KeyPress_1);
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
            this.btnRegistrar.Location = new System.Drawing.Point(123, 256);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(181, 46);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // frmPrimerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondodos;
            this.ClientSize = new System.Drawing.Size(932, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(948, 543);
            this.MinimumSize = new System.Drawing.Size(948, 543);
            this.Name = "frmPrimerUsuario";
            this.Text = "frmPrimerUsuario";
            this.Load += new System.EventHandler(this.frmPrimerUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCorreoRegistrar;
        private System.Windows.Forms.TextBox txtClaveRegistrar;
        private Clases.RedondearBoton btnRegistrar;
    }
}