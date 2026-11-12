using Entidad;
using DatosCS.Conexion;
using Microsoft.Data.SqlClient;


namespace DatosCS.DAO
{
    public class UsuarioDAO
    {

        private ConexionBD conexion = new ConexionBD();


        public Usuario Login(string usuario, string contrasena)
        {

            Usuario user = null;


            using (SqlConnection cn = conexion.ObtenerConexion())
            {

                string query =
                @"SELECT *
                  FROM Usuarios
                  WHERE Usuario=@usuario
                  AND Contrasena=@contrasena";


                SqlCommand cmd = new SqlCommand(query, cn);


                cmd.Parameters.AddWithValue("@usuario", usuario);

                cmd.Parameters.AddWithValue("@contrasena", contrasena);


                cn.Open();


                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {

                    user = new Usuario();


                    user.IdUsuario =
                    Convert.ToInt32(reader["IdUsuario"]);


                    user.Nombre =
                    reader["Nombre"].ToString();


                    user.Apellido =
                    reader["Apellido"].ToString();


                    user.Usuario =
                    reader["Usuario"].ToString();


                    user.Rol =
                    reader["Rol"].ToString();


                }


            }


            return user;

        }


    }
}