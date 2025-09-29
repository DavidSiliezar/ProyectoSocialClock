using Modelos.Entidades;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmRecuperarContraseña : Form
    {
        // 🔹 Instancia única de ServicioDeRecuperacion
        private ServicioDeRecuperacion servicio;

        public frmRecuperarContraseña()
        {
            InitializeComponent();
            servicio = new ServicioDeRecuperacion(); // inicializamos solo una vez
            RedondearPanel(pnlLogin, 40);
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

        private void frmRecuperarContraseña_Load(object sender, EventArgs e)
        {
            
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        // Botón para generar token y enviarlo por correo
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correoUsuario = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(correoUsuario))
            {
                MessageBox.Show("Por favor ingresa tu correo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsEmailValido(correoUsuario))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Usamos la misma instancia para generar el token
                string resultado = servicio.RecuperarContra(correoUsuario);
                MessageBox.Show(resultado, "Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsEmailValido(string email)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        // Botón para verificar token
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string tokenIngresado = txtToken.Text.Trim();

            if (string.IsNullOrEmpty(tokenIngresado))
            {
                MessageBox.Show("Por favor ingrese el token.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 🔹 Usamos la misma instancia para validar
                if (servicio.ValidarToken(tokenIngresado))
                {
                    MessageBox.Show("Exito!","Bienvenid@");
                    frmCrearNuevaClave fe = new frmCrearNuevaClave();
                    fe.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El token ingresado es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.Text = "";
                    txtToken.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Validaciones
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && c != '_' && c != '.' && c != '-' && c != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras, números, @, guion bajo, punto y guion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtToken_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras y números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }

        }
        #endregion

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin fe = new frmLogin();
            fe.Show();
            this.Hide();
        }
    }
}
