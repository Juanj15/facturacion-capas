using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DALLogin
    {
        private DATConexion conexion = new DATConexion();

        public bool ValidarLogin(string usuario, string contraseña)
        {
            try
            {
                SqlConnection conn = conexion.OpenConnection();

                string query = "SELECT COUNT(*) FROM TBLSEGURIDAD " +
                               "WHERE StrUsuario = @usuario AND StrClave = @clave";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", contraseña);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de datos: " + ex.Message);
            }
            finally
            {
                conexion.CloseConnection();
            }
        }
    }
}