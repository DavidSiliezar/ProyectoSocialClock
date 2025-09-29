using Modelos;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.Globalization;

namespace Vistas.Formularios
{
    public partial class frmEstadisticas : Form
    {
        int month, year;

        public frmEstadisticas()
        {
            InitializeComponent();
            RedondearPanel(pnlEstadisticas, 40);
            ocultarSubTabla(false);
            MostrarEstudiantePrimerAño();
            MostrarEstudianteSegundoAño();
            MostrarEstudianteTercerAño();
            MostrarCantidadEstudiantesPrimer();
            MostrarCantidadEstudiantesSegundo();
            MostrarCantidadEstudiantestercer();
        }

        //Metodo para redondear las esquinas de los paneles
        //Metodo para redondear las esquinas de los paneles
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

        //Método para ocultar subtablas
        private void ocultarSubTabla(bool estado)
        {
            pnlPrimerAño.Visible = estado;
            panel18.Visible = estado;
            pnlSegundoAño.Visible = estado;
            panel15.Visible = estado;
            pnlTercerAño.Visible = estado;
            panel12.Visible = estado;
        }

        private void MostrarEstudiantePrimerAño()
        {
            dgvPrimerAnio.DataSource = null;
            dgvPrimerAnio.DataSource = Estadisticas.MostrarAlumnosPrimer();
        }

        private void MostrarEstudianteSegundoAño()
        {
            dgvSegundoAnio.DataSource = null;
            dgvSegundoAnio.DataSource = Estadisticas.MostrarAlumnosSegundo();
        }

        private void MostrarEstudianteTercerAño()
        {
            dgvTercerAnio.DataSource = null;
            dgvTercerAnio.DataSource = Estadisticas.MostrarAlumnosTercer();
        }

        private void MostrarCantidadEstudiantesPrimer()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {

                    SqlCommand com = new SqlCommand(@"
                    SELECT COUNT(E.idEstudiante)
                    FROM Estudiante E
                    INNER JOIN Esp_Niv_Sec ENS ON E.id_EspNivSec = ENS.idEsp_Niv_Sec
                    INNER JOIN NivelAcademico NA ON ENS.id_NivelAcademico = NA.idNivelAcademico
                    WHERE NA.nombreNivel = 'Primer año'", conexion);
                    object result = com.ExecuteScalar();
                    lblCantidad1.Text = result != null ? result.ToString() : "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }


        }
        private void MostrarCantidadEstudiantesSegundo()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {

                    SqlCommand com = new SqlCommand(@"
                    SELECT COUNT(E.idEstudiante)
                    FROM Estudiante E
                    INNER JOIN Esp_Niv_Sec ENS ON E.id_EspNivSec = ENS.idEsp_Niv_Sec
                    INNER JOIN NivelAcademico NA ON ENS.id_NivelAcademico = NA.idNivelAcademico
                    WHERE NA.nombreNivel = 'Segundo año'", conexion);
                    object result = com.ExecuteScalar();
                    lblCantidad2.Text = result != null ? result.ToString() : "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }


        }
        private void MostrarCantidadEstudiantestercer()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {

                    SqlCommand com = new SqlCommand(@"
                    SELECT COUNT(E.idEstudiante)
                    FROM Estudiante E
                    INNER JOIN Esp_Niv_Sec ENS ON E.id_EspNivSec = ENS.idEsp_Niv_Sec
                    INNER JOIN NivelAcademico NA ON ENS.id_NivelAcademico = NA.idNivelAcademico
                    WHERE NA.nombreNivel = 'Tercer año'", conexion);
                    object result = com.ExecuteScalar();
                    lblCantidad3.Text = result != null ? result.ToString() : "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }


        }

      
     

        #region Metodos para cargar datos que se actualizaran
        private void dgvPrimerAño_DoubleClick(object sender, EventArgs e)
        {

        }
        private void dgvSegundoAño_DoubleClick(object sender, EventArgs e)
        {
     
        }

        private void dgvTercerAño_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dgvEstudiantesRetirados_DoubleClick(object sender, EventArgs e)
        {
   
        }
        #endregion

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            RedondearPanel(pnlEstadisticas, 40);
            //showDays(DateTime.Now.Month, DateTime.Now.Year);
            ocultarSubTabla(false);
            CargarEstadisticasChart2();
            CargarEstadisticasChartPrimer();
            CargarEstadisticasChartSegundo();
            CargarEstadisticasChartTercer();
            lblEstadísticas.Parent = pnlEstadisticas;
            lblEstadísticas.AutoSize = false;
            lblEstadísticas.Dock = DockStyle.Fill;
            lblEstadísticas.TextAlign = ContentAlignment.MiddleCenter;
            lblEstadísticas.BringToFront();
            displayDays();
           

        }
        
       


        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthName + "" + year;


            DateTime StartOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year,month);

            int dayOfWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                diasContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
              UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                diasContainer.Controls.Add(ucDays);
            }
        }
        private void CargarEstadisticasChart2()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                using (SqlCommand comando = new SqlCommand("LabibisPorProyecto1", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        var series = chBarra.Series[0];
                        series.Points.Clear();
                        series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                        

                        while (reader.Read())
                        {
                            string nombreProyecto = reader["Proyecto"] as string ?? "";
                            int cantidadEstudiantes = reader["Alumnos"] == DBNull.Value
                                                      ? 0
                                                      : Convert.ToInt32(reader["Alumnos"]);

                            series.Points.AddXY(nombreProyecto, cantidadEstudiantes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de gráfico de barra: " + ex.Message);
            }

        }
        private void CargarEstadisticasChartPrimer()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                using (SqlCommand comando = new SqlCommand("CantidadAlumnosPrimer", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        var series = chBarraPrimer.Series[0];
                        series.Points.Clear();
                        series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

                        while (reader.Read())
                        {
                            string nombreProyecto = reader["Proyectos"] as string ?? "";
                            int cantidadEstudiantes = reader["N° de estudiantes"] == DBNull.Value
                                                      ? 0
                                                      : Convert.ToInt32(reader["N° de estudiantes"]);

                            series.Points.AddXY(nombreProyecto, cantidadEstudiantes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de gráfico de dona: " + ex.Message);
            }
        }

        private void CargarEstadisticasChartSegundo()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                using (SqlCommand cmd = new SqlCommand("CantidadAlumnosSegundo", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var series = chBarraSegundo.Series[0];
                        series.Points.Clear();
                        series.ChartType =
                            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

                        while (reader.Read())
                        {
                            // Col 0 = Proyectos, Col 1 = N° de estudiantes
                            string nombreProyecto = reader.IsDBNull(0) ? "" : reader.GetString(0);
                            int cantidad = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                            series.Points.AddXY(nombreProyecto, cantidad);
                        }

                        // Opcional: etiquetas visibles con % y valor
                        series.IsValueShownAsLabel = true;
                        series.Label = "#VALX: #VAL (#PERCENT{P0})";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de gráfico circular: " + ex.Message);
            }
        }

        private void CargarEstadisticasChartTercer()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                using (SqlCommand cmd = new SqlCommand("CantidadAlumnosTercer", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var series = chBarraTercer.Series[0];
                        series.Points.Clear();
                        series.ChartType =
                            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

                        while (reader.Read())
                        {
                            // Columna 0 = Proyectos, Columna 1 = N° de estudiantes
                            string nombreProyecto = reader.IsDBNull(0) ? "" : reader.GetString(0);
                            int cantidad = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                            series.Points.AddXY(nombreProyecto, cantidad);
                        }

                        // Opcional: mostrar etiquetas con nombre, valor y %
                        series.IsValueShownAsLabel = true;
                        series.Label = "#VALX: #VAL (#PERCENT{P0})";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de gráfico circular: " + ex.Message);
            }

        }


        ArrayList Proyectos = new ArrayList();
        ArrayList Estudiantes = new ArrayList();
   

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            HomePageStats.SelectedIndex = 1;
        }

        private void frmEstadisticas_Resize(object sender, EventArgs e)
        {
            RedondearPanel(pnlEstadisticas, 40);
            ocultarSubTabla(false);
        }
      

        private void redondearBoton4_Click(object sender, EventArgs e)
        {
            pnlSegundoAño.Visible = false;
            panel15.Visible = false;
            pnlTercerAño.Visible = false;
            panel12.Visible = false;
            if (pnlPrimerAño.Visible == false)
            {
                pnlPrimerAño.Visible = true;
                panel18.Visible = true;
            }
            else
            {
                ocultarSubTabla(false);
            }

            MostrarEstudiantePrimerAño();
        }


        private void redondearBoton2_Click(object sender, EventArgs e)
        {
            pnlPrimerAño.Visible = false;
            panel18.Visible = false;
            pnlSegundoAño.Visible = false;
            panel15.Visible = false;
            if (pnlTercerAño.Visible == false)
            {
                pnlTercerAño.Visible = true;
                panel12.Visible = true;
            }
            else
            {
                ocultarSubTabla(false);
            }

            MostrarEstudianteTercerAño();
        }

        private void redondearBoton3_Click(object sender, EventArgs e)
        {
            pnlPrimerAño.Visible = false;
            panel18.Visible = false;
            pnlTercerAño.Visible = false;
            panel12.Visible = false;
            if (pnlSegundoAño.Visible == false)
            {
                pnlSegundoAño.Visible = true;
                panel15.Visible = true;
            }
            else
            {
                ocultarSubTabla(false);
            }
            MostrarEstudianteSegundoAño();
        }

      

        private void btnAtras_Click(object sender, EventArgs e)
        {
            diasContainer.Controls.Clear();
            month--;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthName + "" + year;

            DateTime StartOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                diasContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                diasContainer.Controls.Add(ucDays);
            }
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            diasContainer.Controls.Clear();
            month++;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthName + "" + year;

            DateTime StartOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                diasContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                diasContainer.Controls.Add(ucDays);
            }
        }
      

        private void monthCalendar2_DateChanged_3(object sender, DateRangeEventArgs e)
        {
            HomePageStats.SelectedIndex = 1;
        }

       
     
    }
}
