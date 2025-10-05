using Modelos;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Clases;

namespace Vistas.Formularios
{
    public partial class frmEvento : Form
    {
       
        public frmEvento()
        {
            InitializeComponent();
            RedondearPanel(pnlTitulo, 30);
            this.dgvEventos.DataBindingComplete += dgvEventos_DataBindingComplete;

        }
        private void RedondearPanel(Panel panel, int radio)
        {
            //Creamos un objeto de tipo GraphicsPath
            GraphicsPath path = new GraphicsPath();
            //Dibujamos la figura
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }


        private void frmEvento_Load(object sender, EventArgs e)
        {
            dtpFechaPublicacion.MinDate = DateTime.Today;
            mostrarEventos();
            txtEvento.Clear();
            lblUsuarioActual.Text = Sesion.NombreUsuario;
            
        }
     

        private void mostrarEventos()
        { 
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = Evento.CargarEvento();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEvento.Text = "";
            txtDescripcion.Text = "";
            dtpFechaEvento.Value = DateTime.Now;
            dtpFechaPublicacion.Value = DateTime.Now;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEvento.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (Sesion.IdUsuario <= 0)
                {
                    MessageBox.Show("No hay usuario en sesión. Inicia sesión nuevamente.");
                    return;
                }
                else
                {
                    try
                    {
                        Evento evento = new Evento();
                        evento.NombreEvento = txtEvento.Text;
                        evento.DescripcionEvento = txtDescripcion.Text;
                        evento.FechaHoraPublicacion = dtpFechaPublicacion.Value;
                        evento.FechaEvento = dtpFechaEvento.Value;
                        evento.IdUsuario = Sesion.IdUsuario;
                        evento.insertarEvento();
                        mostrarEventos();
                        MessageBox.Show("Evento agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al agregar el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            int idEvento = int.Parse(dgvEventos.CurrentRow.Cells[0].Value.ToString());
            string registroEliminar = dgvEventos.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el evento: " + registroEliminar + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (evento.eliminarEvento(idEvento) == true)
                {
                    MessageBox.Show("Evento eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void dgvEventos_DoubleClick(object sender, EventArgs e)
        {
            txtEvento.Text = dgvEventos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvEventos.CurrentRow.Cells[2].Value.ToString();
            dtpFechaEvento.Value = DateTime.Parse(dgvEventos.CurrentRow.Cells[3].Value.ToString());
            dtpFechaPublicacion.Value = DateTime.Parse(dgvEventos.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEvento.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Evento evento = new Evento();
                evento.NombreEvento = txtEvento.Text;
                evento.DescripcionEvento = txtDescripcion.Text;
                evento.FechaEvento = dtpFechaEvento.Value;
                evento.FechaHoraPublicacion = dtpFechaPublicacion.Value;
                int id = int.Parse(dgvEventos.CurrentRow.Cells[0].Value.ToString());
                if (evento.actualizarEvento(id))
                {
                    mostrarEventos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEventos.DataSource = null;
                dgvEventos.DataSource = Evento.BuscarEvento(txtBuscar.Text);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al buscar el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEvento_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this.BeginInvoke(new Action(() => this.ActiveControl = null));
        }

        private void dgvEventos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvEventos.Rows.Count > 0)
            {
                dgvEventos.ClearSelection();
                dgvEventos.CurrentCell = null;
            }
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
