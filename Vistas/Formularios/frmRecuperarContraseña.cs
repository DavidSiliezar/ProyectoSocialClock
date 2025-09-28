using Modelos.Entidades;
using System;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtToken_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
