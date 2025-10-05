using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Sesion
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }


        public static int ObtenerIdPorNombre(string nombreUsuario)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                string comando = "Select idUsuario From Usuario where nombreUsuario = @nombreUsuario";
                using (SqlCommand cmd = new SqlCommand(comando, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    object val = cmd.ExecuteScalar();
                    return (val == null || val == DBNull.Value) ? 0 : Convert.ToInt32(val);
                }
            }
        }
    }
}
