namespace Vistas.Formularios
{
    partial class frmCrearNuevaClave
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
            this.gbCrearUsuario = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnNuevaClave = new Vistas.Clases.RedondearBoton();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblIngresaCorreo = new System.Windows.Forms.Label();
            this.lblIngresaClave = new System.Windows.Forms.Label();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.gbCrearUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCrearUsuario
            // 
            this.gbCrearUsuario.BackgroundImage = global::Vistas.Properties.Resources.fondodos1;
            this.gbCrearUsuario.Controls.Add(this.LblConfirmar);
            this.gbCrearUsuario.Controls.Add(this.lblIngresaClave);
            this.gbCrearUsuario.Controls.Add(this.lblIngresaCorreo);
            this.gbCrearUsuario.Controls.Add(this.txtCorreo);
            this.gbCrearUsuario.Controls.Add(this.btnNuevaClave);
            this.gbCrearUsuario.Controls.Add(this.txtConfirmarClave);
            this.gbCrearUsuario.Controls.Add(this.txtClave);
            this.gbCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCrearUsuario.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrearUsuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbCrearUsuario.Location = new System.Drawing.Point(0, 0);
            this.gbCrearUsuario.Margin = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.gbCrearUsuario.Name = "gbCrearUsuario";
            this.gbCrearUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.gbCrearUsuario.Size = new System.Drawing.Size(1158, 560);
            this.gbCrearUsuario.TabIndex = 6;
            this.gbCrearUsuario.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Location = new System.Drawing.Point(288, 141);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.MaxLength = 45;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '*';
            this.txtCorreo.Size = new System.Drawing.Size(303, 41);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // btnNuevaClave
            // 
            this.btnNuevaClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.btnNuevaClave.BorderColor = System.Drawing.Color.Transparent;
            this.btnNuevaClave.BorderRadius = 30;
            this.btnNuevaClave.BorderSize = 0;
            this.btnNuevaClave.FlatAppearance.BorderSize = 0;
            this.btnNuevaClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaClave.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaClave.ForeColor = System.Drawing.Color.White;
            this.btnNuevaClave.Location = new System.Drawing.Point(663, 227);
            this.btnNuevaClave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnNuevaClave.Name = "btnNuevaClave";
            this.btnNuevaClave.Size = new System.Drawing.Size(369, 141);
            this.btnNuevaClave.TabIndex = 9;
            this.btnNuevaClave.Text = "Confirmar nueva contraseña";
            this.btnNuevaClave.UseVisualStyleBackColor = false;
            this.btnNuevaClave.Click += new System.EventHandler(this.btnNuevaClave_Click);
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmarClave.Location = new System.Drawing.Point(288, 449);
            this.txtConfirmarClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarClave.MaxLength = 10;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(303, 41);
            this.txtConfirmarClave.TabIndex = 8;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.Location = new System.Drawing.Point(288, 294);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.MaxLength = 10;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(303, 41);
            this.txtClave.TabIndex = 7;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // lblIngresaCorreo
            // 
            this.lblIngresaCorreo.AutoSize = true;
            this.lblIngresaCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.lblIngresaCorreo.ForeColor = System.Drawing.Color.White;
            this.lblIngresaCorreo.Location = new System.Drawing.Point(12, 38);
            this.lblIngresaCorreo.Name = "lblIngresaCorreo";
            this.lblIngresaCorreo.Size = new System.Drawing.Size(433, 33);
            this.lblIngresaCorreo.TabIndex = 11;
            this.lblIngresaCorreo.Text = "Ingresa tu correo Electronico : ";
            // 
            // lblIngresaClave
            // 
            this.lblIngresaClave.AutoSize = true;
            this.lblIngresaClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.lblIngresaClave.ForeColor = System.Drawing.Color.White;
            this.lblIngresaClave.Location = new System.Drawing.Point(18, 227);
            this.lblIngresaClave.Name = "lblIngresaClave";
            this.lblIngresaClave.Size = new System.Drawing.Size(414, 33);
            this.lblIngresaClave.TabIndex = 12;
            this.lblIngresaClave.Text = "Ingresa tu nueva contraseña :";
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.LblConfirmar.ForeColor = System.Drawing.Color.White;
            this.LblConfirmar.Location = new System.Drawing.Point(18, 385);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(476, 33);
            this.LblConfirmar.TabIndex = 13;
            this.LblConfirmar.Text = "Confirma de nuevo tu contraseña :";
            // 
            // frmCrearNuevaClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 560);
            this.Controls.Add(this.gbCrearUsuario);
            this.Name = "frmCrearNuevaClave";
            this.Text = "frmCrearNuevaClave";
            this.Load += new System.EventHandler(this.frmCrearNuevaClave_Load);
            this.gbCrearUsuario.ResumeLayout(false);
            this.gbCrearUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtClave;
        private Clases.RedondearBoton btnNuevaClave;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblIngresaCorreo;
        private System.Windows.Forms.Label LblConfirmar;
        private System.Windows.Forms.Label lblIngresaClave;
    }
}