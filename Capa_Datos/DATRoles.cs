using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;  // ✅ La librería recomendada en .NET 8

namespace Capa_Datos
{
    public class DATRoles
    {
        private DATConexion conexion = new DATConexion();

        //SqlDataReader dataReader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();


        /// Método para Select  Roles
        /// 

        public DataTable SelectRoles()
        {
            DataTable table = new DataTable();
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_ObtenerRolesActivos";
                comando.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    table.Load(dataReader);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al consultar roles: " + ex.Message, ex);
            }
            finally
            {
                conexion.CloseConnection();
            }
            return table;
        }

    }
}
