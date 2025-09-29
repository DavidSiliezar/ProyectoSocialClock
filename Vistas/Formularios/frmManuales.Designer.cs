namespace Vistas.Formularios
{
    partial class frmManuales
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
            this.btnManuales = new Vistas.Clases.RedondearBoton();
            this.SuspendLayout();
            // 
            // btnManuales
            // 
            this.btnManuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(56)))));
            this.btnManuales.BorderColor = System.Drawing.Color.Transparent;
            this.btnManuales.BorderRadius = 30;
            this.btnManuales.BorderSize = 0;
            this.btnManuales.FlatAppearance.BorderSize = 0;
            this.btnManuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManuales.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManuales.ForeColor = System.Drawing.Color.White;
            this.btnManuales.Location = new System.Drawing.Point(331, 205);
            this.btnManuales.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnManuales.Name = "btnManuales";
            this.btnManuales.Size = new System.Drawing.Size(496, 255);
            this.btnManuales.TabIndex = 21;
            this.btnManuales.Text = "Descargar Manuales";
            this.btnManuales.UseVisualStyleBackColor = false;
            this.btnManuales.Click += new System.EventHandler(this.btnManuales_Click);
            // 
            // frmManuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondodos;
            this.ClientSize = new System.Drawing.Size(1202, 642);
            this.Controls.Add(this.btnManuales);
            this.Name = "frmManuales";
            this.Text = "frmManuales";
            this.Load += new System.EventHandler(this.frmManuales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Clases.RedondearBoton btnManuales;
    }
}