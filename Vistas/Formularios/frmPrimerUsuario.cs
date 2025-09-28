using Modelos;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmPrimerUsuario : Form
    {
        private bool suppressTextChanged = false;

        public frmPrimerUsuario()
        {
            InitializeComponent();
        }

        private void frmPrimerUsuario_Load(object sender, EventArgs e)
        {
            // Ocultar contraseña con asteriscos
            txtClaveRegistrar.UseSystemPasswordChar = true;

            // Eventos de validación
            txtCorreoRegistrar.KeyPress += TxtCorreoRegistrar_KeyPress;
            txtCorreoRegistrar.TextChanged += TxtCorreoRegistrar_TextChanged;

            txtClaveRegistrar.KeyPress += TxtClaveRegistrar_KeyPress;
            txtClaveRegistrar.TextChanged += TxtClaveRegistrar_TextChanged;

            // Bloquear pegar
            txtCorreoRegistrar.ShortcutsEnabled = false;
            txtClaveRegistrar.ShortcutsEnabled = false;
        }

        // VALIDACIÓN CORREO
        private void TxtCorreoRegistrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '@' || e.KeyChar == '.' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números, guion bajo (_), arroba (@) y punto (.) en el correo.", "Caracter no permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtCorreoRegistrar_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;

            string original = txtCorreoRegistrar.Text;
            string cleaned = new string(original.Where(ch => char.IsLetterOrDigit(ch) || ch == '_' || ch == '@' || ch == '.').ToArray());

            if (cleaned != original)
            {
                suppressTextChanged = true;
                int sel = txtCorreoRegistrar.SelectionStart;
                txtCorreoRegistrar.Text = cleaned;
                txtCorreoRegistrar.SelectionStart = Math.Min(sel, cleaned.Length);
                suppressTextChanged = false;

                MessageBox.Show("Solo se permiten letras, números, guion bajo (_), arroba (@) y punto (.) en el correo.", "Caracter no permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // VALIDACIÓN CLAVE
        private void TxtClaveRegistrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en la clave.", "Caracter no permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtClaveRegistrar_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;

            string original = txtClaveRegistrar.Text;
            string cleaned = new string(original.Where(char.IsDigit).ToArray());

            if (cleaned != original)
            {
                suppressTextChanged = true;
                int sel = txtClaveRegistrar.SelectionStart;
                txtClaveRegistrar.Text = cleaned;
                txtClaveRegistrar.SelectionStart = Math.Min(sel, cleaned.Length);
                suppressTextChanged = false;

                MessageBox.Show("Solo se permiten números en la clave.", "Caracter no permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // VALIDAR SI EL CORREO EXISTE
        private bool CorreoExiste(string correo)
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE nombreUsuario = @correo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@correo", correo);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // BOTÓN REGISTRAR
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = txtCorreoRegistrar.Text.Trim();
                string clave = txtClaveRegistrar.Text.Trim();

                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Debe ingresar un correo y una clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CorreoExiste(correo))
                {
                    MessageBox.Show("El correo ya está registrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Usuario nuevo = new Usuario
                {
                    NombreUsuario = correo,
                    Clave = BCrypt.Net.BCrypt.HashPassword(clave), // Hasheada por la encriptacion
                    EstadoUsuario = true,
                    Id_Rol = 1
                };

                if (nuevo.InsertarUsuario())
                {
                    // Mensaje en pantalla
                    MessageBox.Show($"¡Bienvenido al sistema Social Clock, {correo}!", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Enviar correo de bienvenida
                    EnviarCorreoBienvenida(correo);

                    // Abrir formulario principal
                    frmSocialClock menu = new frmSocialClock();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MÉTODO PARA ENVIAR CORREO
        private void EnviarCorreoBienvenida(string correoDestino)
        {
            try
            {
                using (var mailService = new SoporteDeContrasena("socialclock7@gmail.com", "fvtvqapfoalythgd"))
                {
                    bool emailEnviado = mailService.EnviarMail(
                        subject: "Bienvenido a Social Clock",
                        body: $"¡Hola! {correoDestino}\n\nTu cuenta en el sistema Social Clock ha sido creada correctamente.\n\n¡Bienvenido!",
                        recipientMail: new List<string> { correoDestino }
                    );

                    if (!emailEnviado)
                        MessageBox.Show($"No se pudo enviar el correo de bienvenida a {correoDestino}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enviando correo de bienvenida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
