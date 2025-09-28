using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmCrearNuevaClave : Form
    {
        public frmCrearNuevaClave()
        {
            InitializeComponent();
            RedondearPanel(pnlNuevaClave, 40);
        }

        private void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        private void btnNuevaClave_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = txtCorreo.Text.Trim();
                string clave = txtClave.Text.Trim();
                string confirmarClave = txtConfirmarClave.Text.Trim();

                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(confirmarClave))
                {
                    MessageBox.Show("Por favor completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que las contraseñas coincidan
                if (clave != confirmarClave)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear objeto Usuario y actualizar contraseña
                Usuario user = new Usuario
                {
                    NombreUsuario = correo,
                    Clave = BCrypt.Net.BCrypt.HashPassword(clave)
                };

                if (user.ActualizarClaveUsuario())
                {
                    // Guardar en memoria para uso durante la sesión
                    Usuario.ClaveEnMemoria = user.Clave;

                    // Mensaje de éxito
                    MessageBox.Show("¡Éxito! Cambios guardados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir frmLogin y cerrar el actual
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCrearNuevaClave_Load(object sender, EventArgs e)
        {
            txtCorreo.UseSystemPasswordChar = false;
            txtCorreo.PasswordChar = '\0';
            RedondearPanel(pnlNuevaClave, 40);
        }

        #region
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && c != '_' && c != '.' && c != '-' && c != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras, números, @, guion bajo, punto y guion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && c != '@' && c != '_' && c != '.' && c != '!' && c != '#' && c != '$' && c != '%' && c != '&' && c != '*' && c != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras, números y caracteres especiales (@ _ . ! # $ % & *)",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && c != '@' && c != '_' && c != '.' && c != '!' && c != '#' && c != '$' && c != '%' && c != '&' && c != '*' && c != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras, números y caracteres especiales (@ _ . ! # $ % & *)",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        #endregion
    }
}
