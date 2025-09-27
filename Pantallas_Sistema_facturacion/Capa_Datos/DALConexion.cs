using Microsoft.Data.SqlClient; // Cambiado de System.Data.SqlClient
using System.Data;

namespace Capa_Datos
{
    public class DALConexion
    {
        ***REMOVED***

        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
