using Modelos;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            RedondearPanel(pnlLogin, 40);

            // Bloquear pegado en los textbox
            txtUsuario.ShortcutsEnabled = false;
            txtClave.ShortcutsEnabled = false;
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
           }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string clave = txtClave.Text;
            string nombreUsuario = txtUsuario.Text;

            Usuario usuario = new Usuario();

            if (usuario.VerificarLogin(nombreUsuario, clave))
            {
                if (Usuario.IdentificarEstado(nombreUsuario) == 1)
                {
                    MessageBox.Show("Los usuarios inactivos no puden iniciar sesión", "¡Lo sentimos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Usuario.IdentificarPrimerLogin(nombreUsuario) == 1)
                {
                    int id_Rol = Usuario.IdentificarRol(nombreUsuario);
                    if (id_Rol == 1)
                    {
                        frmSocialClock fe = new frmSocialClock();
                        fe.Show();
                        this.Hide();
                        MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else if (id_Rol == 2)
                    {
                        frmSocialClock_Colaborador fe = new frmSocialClock_Colaborador();
                        fe.Show();
                        this.Hide();
                        MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos, hubo un error al encontrar su rol", "Error");
                    }
                }
                else if(Usuario.IdentificarPrimerLogin(nombreUsuario) == 0)
                {
                    frmCambiarClave fe = new frmCambiarClave();
                    this.Hide();
                    fe.Show();
                   
                    MessageBox.Show("Es su primer inicio de sesión, así que debe cambiar su contraseña temporal por una propia. " +
                        "\n Asegurese de elegir una contraseña que recordará", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo identificar su inicio de sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El usuario y/o clave no coinciden", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
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

        // Bloquear pegado desde menú contextual
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                MessageBox.Show("No se permite pegar contenido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // Bloquear
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnOlvidarClave_Click(object sender, EventArgs e)
        {
            try
            {
                frmRecuperarContraseña recuperar = new frmRecuperarContraseña();
                recuperar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrimerUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrimerUsuario frm = new frmPrimerUsuario();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de creación de usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
