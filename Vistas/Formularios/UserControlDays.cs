using Modelos;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class UserControlDays : UserControl
    {
        public static string static_dia;
        private int idEvento;
        private int _dayNumber;
        private DateTime _date;

        public UserControlDays()
        {
            InitializeComponent();
            displayEvent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            if (_dayNumber > 0)
            {
                displayEvent();
            }
        }
        public void SetDay(int day)
        {
            
        }

        public void days(int numday)
        {
            lblDays.Text = numday + "";
            _dayNumber = numday;
            lblDays.Text = numday.ToString();
            _date = new DateTime(frmEstadisticas.static_año, frmEstadisticas.static_mes, _dayNumber);
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_dia = lblDays.Text;
            timer1.Start();
            frmEvento eventForm = new frmEvento();
            eventForm.Show(); 
            displayEvent(); 
        }

        private void displayEvent()
        {
            using (SqlConnection conexion = Conexion.Conectar())
            using (SqlCommand cmd = conexion.CreateCommand())
            {
                cmd.CommandText = "SELECT TOP 1 NombreEvento FROM Evento WHERE fechaEvento = @fecha ORDER BY idEvento DESC";
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = _date.Date;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblEvent.Text = reader["NombreEvento"].ToString();
                    }

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
