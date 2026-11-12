using Microsoft.Data.SqlClient;

namespace DatosCS.Conexion
{
    public class ConexionBD
    {

        private readonly string cadena =
            "Server=.;Database=AcademiaIdiomasDB;Trusted_Connection=True;TrustServerCertificate=True";


        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadena);

            return conexion;
        }

    }
}
