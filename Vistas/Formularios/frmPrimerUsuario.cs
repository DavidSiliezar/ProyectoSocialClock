using Modelos;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmPrimerUsuario : Form
    {

        public frmPrimerUsuario()
        {
            
            
                InitializeComponent();
                RedondearPanel(pnlPrimerUsuario, 40);

            
                
            
        }
        
      

        private void frmPrimerUsuario_Load(object sender, EventArgs e)
        {
            
                // Ocultar contraseña con asteriscos
                txtClaveRegistrar.UseSystemPasswordChar = true;

                // Bloquear pegar
                txtCorreoRegistrar.ShortcutsEnabled = false;
                txtClaveRegistrar.ShortcutsEnabled = false;
                RedondearPanel(pnlPrimerUsuario, 40);
            

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

        // BOTÓN REGISTRAR
        private void btnRegistrar_Click_1(object sender, EventArgs e)
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
                    EstadoUsuario = false,
                    Id_Rol = 1,
                    PrimerLogin = 1
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

        #region Validaciones
        private void txtCorreoRegistrar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && c != '_' && c != '.' && c != '-' && c != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras, números, @, guion bajo, punto y guion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtClaveRegistrar_KeyPress_1(object sender, KeyPressEventArgs e)
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
