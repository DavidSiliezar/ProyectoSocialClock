using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;





namespace Modelos.Entidades
{
    public class Estadisticas
    {
        private int idEstudiante;
        private int idProyecto;
        private string nombreProyecto;

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }



        public static DataTable CargarEstadisticas()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "SELECT  Proyecto.nombreProyecto AS Proyecto," +
                "\r\nCOUNT(E.idEstudiante) AS Alumnos\r\nFROM Proyecto  " +
                " \r\nLEFT JOIN\r\nEstudiante E ON E.id_Proyecto = Proyecto.idProyecto\r" +
                "\nGROUP BY Proyecto.nombreProyecto\r\nORDER BY Proyecto;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        public static DataTable MostrarAlumnosPrimer()
        {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "  SELECT \r\nProyecto.nombreProyecto AS [Proyectos],\r\n   " +
                   " COUNT(Estudiante.idEstudiante) AS [N° de estudiantes]\r\nFROM \r\n    " +
                   "Proyecto\r\nLEFT JOIN Estudiante \r\n    ON Proyecto.idProyecto = Estudiante.id_Proyecto" +
                   "\r\nINNER JOIN Esp_Niv_Sec \r\n    ON Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec\r\n" +
                   "INNER JOIN NivelAcademico \r\n    ON Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
                   "\r\nWHERE \r\n NivelAcademico.nombreNivel = 'Primer año'\r\n" +
                   "GROUP BY \r\n    Proyecto.nombreProyecto\r\nORDER BY \r\n " +
                   "   Proyecto.nombreProyecto;";
                SqlDataAdapter ad = new SqlDataAdapter(consultaQuery, conexion);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                return dt;
        }

        public static DataTable MostrarAlumnosSegundo()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "  SELECT \r\nProyecto.nombreProyecto AS [Proyectos],\r\n   " +
               " COUNT(Estudiante.idEstudiante) AS [N° de estudiantes]\r\nFROM \r\n    " +
               "Proyecto\r\nLEFT JOIN Estudiante \r\n    ON Proyecto.idProyecto = Estudiante.id_Proyecto" +
               "\r\nINNER JOIN Esp_Niv_Sec \r\n    ON Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec\r\n" +
               "INNER JOIN NivelAcademico \r\n    ON Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
               "\r\nWHERE \r\n NivelAcademico.nombreNivel = 'Segundo año'\r\n" +
               "GROUP BY \r\n    Proyecto.nombreProyecto\r\nORDER BY \r\n " +
               "   Proyecto.nombreProyecto;";
            SqlDataAdapter ad = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public static DataTable MostrarAlumnosTercer()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "  SELECT \r\nProyecto.nombreProyecto AS [Proyectos],\r\n   " +
               " COUNT(Estudiante.idEstudiante) AS [N° de estudiantes]\r\nFROM \r\n    " +
               "Proyecto\r\nLEFT JOIN Estudiante \r\n    ON Proyecto.idProyecto = Estudiante.id_Proyecto" +
               "\r\nINNER JOIN Esp_Niv_Sec \r\n    ON Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec\r\n" +
               "INNER JOIN NivelAcademico \r\n    ON Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico" +
               "\r\nWHERE \r\n NivelAcademico.nombreNivel = 'Tercer año'\r\n" +
               "GROUP BY \r\n    Proyecto.nombreProyecto\r\nORDER BY \r\n " +
               "   Proyecto.nombreProyecto;";
            SqlDataAdapter ad = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

       


    }
}
