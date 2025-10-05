namespace Vistas.Formularios
{
    partial class frmCambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarClave));
            this.pnlNuevaClave = new System.Windows.Forms.Panel();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIngresaCorreo = new System.Windows.Forms.Label();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.lblIngresaClave = new System.Windows.Forms.Label();
            this.btnNuevaClave = new Vistas.Clases.RedondearBoton();
            this.pnlNuevaClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNuevaClave
            // 
            this.pnlNuevaClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.pnlNuevaClave.Controls.Add(this.txtConfirmarClave);
            this.pnlNuevaClave.Controls.Add(this.txtCorreo);
            this.pnlNuevaClave.Controls.Add(this.txtClave);
            this.pnlNuevaClave.Controls.Add(this.pictureBox3);
            this.pnlNuevaClave.Controls.Add(this.pictureBox2);
            this.pnlNuevaClave.Controls.Add(this.pictureBox1);
            this.pnlNuevaClave.Controls.Add(this.lblIngresaCorreo);
            this.pnlNuevaClave.Controls.Add(this.LblConfirmar);
            this.pnlNuevaClave.Controls.Add(this.lblIngresaClave);
            this.pnlNuevaClave.Location = new System.Drawing.Point(135, 89);
            this.pnlNuevaClave.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNuevaClave.Name = "pnlNuevaClave";
            this.pnlNuevaClave.Size = new System.Drawing.Size(580, 453);
            this.pnlNuevaClave.TabIndex = 15;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmarClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(165, 380);
            this.txtConfirmarClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarClave.MaxLength = 10;
            this.txtConfirmarClave.Multiline = true;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(304, 31);
            this.txtConfirmarClave.TabIndex = 18;
            this.txtConfirmarClave.WordWrap = false;
            this.txtConfirmarClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarClave_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(177, 97);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(304, 31);
            this.txtCorreo.TabIndex = 17;
            this.txtCorreo.WordWrap = false;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(165, 231);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.MaxLength = 10;
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(304, 31);
            this.txtClave.TabIndex = 15;
            this.txtClave.WordWrap = false;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_21_195419;
            this.pictureBox3.Location = new System.Drawing.Point(105, 363);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(397, 63);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_21_195419;
            this.pictureBox2.Location = new System.Drawing.Point(105, 215);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(397, 63);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_21_195352;
            this.pictureBox1.Location = new System.Drawing.Point(105, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 78);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblIngresaCorreo
            // 
            this.lblIngresaCorreo.AutoSize = true;
            this.lblIngresaCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresaCorreo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresaCorreo.ForeColor = System.Drawing.Color.White;
            this.lblIngresaCorreo.Location = new System.Drawing.Point(43, 27);
            this.lblIngresaCorreo.Name = "lblIngresaCorreo";
            this.lblIngresaCorreo.Size = new System.Drawing.Size(388, 30);
            this.lblIngresaCorreo.TabIndex = 11;
            this.lblIngresaCorreo.Text = "Ingresa tu correo Electronico : ";
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.LblConfirmar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmar.ForeColor = System.Drawing.Color.White;
            this.LblConfirmar.Location = new System.Drawing.Point(43, 314);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(313, 30);
            this.LblConfirmar.TabIndex = 13;
            this.LblConfirmar.Text = "Confirma tu contraseña :";
            // 
            // lblIngresaClave
            // 
            this.lblIngresaClave.AutoSize = true;
            this.lblIngresaClave.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresaClave.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresaClave.ForeColor = System.Drawing.Color.White;
            this.lblIngresaClave.Location = new System.Drawing.Point(43, 174);
            this.lblIngresaClave.Name = "lblIngresaClave";
            this.lblIngresaClave.Size = new System.Drawing.Size(458, 30);
            this.lblIngresaClave.TabIndex = 12;
            this.lblIngresaClave.Text = "Ingresa tu contraseña personalizada:";
            // 
            // btnNuevaClave
            // 
            this.btnNuevaClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.btnNuevaClave.BorderColor = System.Drawing.Color.Transparent;
            this.btnNuevaClave.BorderRadius = 30;
            this.btnNuevaClave.BorderSize = 0;
            this.btnNuevaClave.FlatAppearance.BorderSize = 0;
            this.btnNuevaClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaClave.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaClave.ForeColor = System.Drawing.Color.White;
            this.btnNuevaClave.Location = new System.Drawing.Point(775, 242);
            this.btnNuevaClave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnNuevaClave.Name = "btnNuevaClave";
            this.btnNuevaClave.Size = new System.Drawing.Size(369, 137);
            this.btnNuevaClave.TabIndex = 19;
            this.btnNuevaClave.Text = "Confirmar nueva contraseña";
            this.btnNuevaClave.UseVisualStyleBackColor = false;
            this.btnNuevaClave.Click += new System.EventHandler(this.btnNuevaClave_Click);
            // 
            // frmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondodos;
            this.ClientSize = new System.Drawing.Size(1241, 612);
            this.Controls.Add(this.btnNuevaClave);
            this.Controls.Add(this.pnlNuevaClave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1259, 659);
            this.MinimumSize = new System.Drawing.Size(1259, 659);
            this.Name = "frmCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.frmCambiarClave_Load);
            this.pnlNuevaClave.ResumeLayout(false);
            this.pnlNuevaClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNuevaClave;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIngresaCorreo;
        private System.Windows.Forms.Label LblConfirmar;
        private System.Windows.Forms.Label lblIngresaClave;
        private Clases.RedondearBoton btnNuevaClave;
    }
}