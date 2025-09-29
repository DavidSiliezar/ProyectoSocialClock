using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmManuales : Form
    {
        public frmManuales()
        {
            InitializeComponent();
        }

        private void frmManuales_Load(object sender, EventArgs e)
        {
           
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

        private void btnManuales_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
        "¿Qué manual quieres abrir?\n\nSí = Manual Técnico\nNo = Manual de Usuario",
        "Abrir Manual",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                AbrirManual("Manual_Tecnico.pdf");
            }
            else if (opcion == DialogResult.No)
            {
                AbrirManual("Manual_Usuario.pdf");
            }
        }

        private void AbrirManual(string nombreArchivo)
        {
            string ruta = Path.Combine(Application.StartupPath, "Manuales", nombreArchivo);

            if (File.Exists(ruta))
            {
                Process.Start(ruta); // abre el PDF con el lector predeterminado
            }
            else
            {
                MessageBox.Show($"No se encontró el archivo {nombreArchivo} en la carpeta Manuales.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
