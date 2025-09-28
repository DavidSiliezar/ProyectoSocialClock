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
            this.txtCorreoRegistrar = new System.Windows.Forms.TextBox();
            this.txtClaveRegistrar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.lblBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Image = global::Vistas.Properties.Resources.fondo;
            this.lblBienvenida.Location = new System.Drawing.Point(311, 27);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(534, 46);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido a Social Clock  ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Image = global::Vistas.Properties.Resources.fondo;
            this.lblCorreo.Location = new System.Drawing.Point(26, 152);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(447, 36);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Ingrese su correo electronico :";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Image = global::Vistas.Properties.Resources.fondo;
            this.lblClave.Location = new System.Drawing.Point(26, 333);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(309, 36);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Cree su contraseña :";
            // 
            // txtCorreoRegistrar
            // 
            this.txtCorreoRegistrar.Location = new System.Drawing.Point(538, 165);
            this.txtCorreoRegistrar.Name = "txtCorreoRegistrar";
            this.txtCorreoRegistrar.Size = new System.Drawing.Size(280, 22);
            this.txtCorreoRegistrar.TabIndex = 3;
         //   this.txtCorreoRegistrar.TextChanged += new System.EventHandler(this.txtCorreoRegistrar_TextChanged);
            // 
            // txtClaveRegistrar
            // 
            this.txtClaveRegistrar.Location = new System.Drawing.Point(404, 346);
            this.txtClaveRegistrar.Name = "txtClaveRegistrar";
            this.txtClaveRegistrar.Size = new System.Drawing.Size(414, 22);
            this.txtClaveRegistrar.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::Vistas.Properties.Resources.fondodos;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::Vistas.Properties.Resources.fondodos;
            this.btnRegistrar.Location = new System.Drawing.Point(895, 152);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(204, 217);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmPrimerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1145, 604);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtClaveRegistrar);
            this.Controls.Add(this.txtCorreoRegistrar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrimerUsuario";
            this.Text = "frmPrimerUsuario";
            this.Load += new System.EventHandler(this.frmPrimerUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtCorreoRegistrar;
        private System.Windows.Forms.TextBox txtClaveRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}