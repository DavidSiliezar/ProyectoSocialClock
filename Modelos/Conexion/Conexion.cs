using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows;

namespace Modelos
{
    public class Conexion
    {
        private static string servidor = "abra\\SQLEXPRESS";
        private static string basedeDatos = "Social_Clock";


        public static SqlConnection Conectar()
        {
            try
            {
                string cadena = $"Data Source= {servidor}; Initial Catalog={basedeDatos}; Integrated Security=true;";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar al servidor" + ex, "Error de Conexion", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }
    }
}
