using Microsoft.Data.SqlClient; // Cambiado de System.Data.SqlClient
using System.Data;

namespace Capa_Datos
{
    public class DALConexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=tcp:srv-winforms-g7.database.windows.net,1433;Initial Catalog=DB-facturacion-g7;Persist Security Info=False;User ID=admin-g7;Password=!myA5x5WmSTqp8W;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

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
