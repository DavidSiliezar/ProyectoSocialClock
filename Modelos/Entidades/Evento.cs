using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
namespace Modelos.Entidades
{
    public class Evento
    {
        private int idEvento;
        private string nombreEvento;
        private string descripcionEvento;
        private DateTime fechaEvento;
        private DateTime fechaHoraPublicacion;
        private int idUsuario;
        private string nombreUsuario;

        public int IdEvento { get => idEvento; set => idEvento = value; }
        public string NombreEvento { get => nombreEvento; set => nombreEvento = value; }
        public string DescripcionEvento { get => descripcionEvento; set => descripcionEvento = value; }
        public DateTime FechaEvento { get => fechaEvento; set => fechaEvento = value; }
        public DateTime FechaHoraPublicacion { get => fechaHoraPublicacion; set => fechaHoraPublicacion = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        public static  DataTable CargarEvento()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "SELECT e.idEvento As [N°],\r\n    e.nombreEvento        AS [Evento],\r\n   " +
                    " e.descripcionEvento   AS [Descripción],\r\n    e.fechaHoraPublicacion AS [Fecha de publicación],\r\n " +
                    "   e.fechaEvento         AS [Fecha del evento],\r\n    u.nombreUsuario   " +
                    "    AS [Nombre del usuario]\r\nFROM Evento AS e\r\nINNER JOIN Usuario AS u \r\n    ON e.idUsuario = u.idUsuario;";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable tablaCargar = new DataTable();
                add.Fill(tablaCargar);
                return tablaCargar;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error al cargar los eventos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool insertarEvento()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "INSERT INTO Evento (nombreEvento, descripcionEvento, fechaEvento, fechaHoraPublicacion, idUsuario) " +
                    "VALUES (@nombreEvento, @descripcionEvento, @fechaEvento, @fechaHoraPublicacion, @idUsuario)";
                SqlCommand comando = new SqlCommand(consultaQuery, conexion);
                comando.Parameters.AddWithValue("@idEvento", idEvento);
                comando.Parameters.AddWithValue("@nombreEvento", NombreEvento);
                comando.Parameters.AddWithValue("@descripcionEvento", DescripcionEvento);
                comando.Parameters.AddWithValue("@fechaEvento", FechaEvento);
                comando.Parameters.AddWithValue("@fechaHoraPublicacion", FechaHoraPublicacion);
                comando.Parameters.AddWithValue("@idUsuario", Sesion.IdUsuario);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool eliminarEvento(int id)
        {
            SqlConnection conexione = Conexion.Conectar();
            string consultaDelete = "Delete from Evento where idEvento = @idEvento";
            SqlCommand delete = new SqlCommand(consultaDelete, conexione);
            delete.Parameters.AddWithValue("@idEvento", id);
            if (delete.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool actualizarEvento(int id)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaUpdate = "UPDATE Evento set nombreEvento = @nombreEvento, descripcionEvento = @descripcionEvento," +
                    " fechaEvento = @fechaEvento, fechaHoraPublicacion = @fechaHoraPublicacion where idEvento = @idEvento";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@idEvento", idEvento);
                actualizar.Parameters.AddWithValue("@nombreEvento",nombreEvento);
                actualizar.Parameters.AddWithValue("@descripcionEvento", descripcionEvento);
                actualizar.Parameters.AddWithValue("@fechaEvento", fechaEvento);
                actualizar.Parameters.AddWithValue("@fechaHoraPublicacion", fechaHoraPublicacion);
                actualizar.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados", "Actualizar");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos"+ex);
                return false ;
            }
        }

        public static DataTable BuscarEvento(string termino)
        {
            SqlConnection conexion = Conexion.Conectar();
            string comando = $"Select * From Evento Where nombreEvento Like '%{termino}%'; ";
            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);  
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }    
    }
}
