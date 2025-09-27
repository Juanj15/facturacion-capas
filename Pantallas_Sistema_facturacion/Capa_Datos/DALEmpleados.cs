using Microsoft.Data.SqlClient; // Cambiado de System.Data.SqlClient
using System;
using System.Data;

namespace Capa_Datos
{
    public class DALEmpleados
    {
        private DALConexion conexion = new DALConexion();

        SqlDataReader dataReader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        /// Método para Insertar "Create" los datos
        /// </summary>
        public void CreateEmpleado(string strNombre, int NumDocumento, string StrDireccion, string StrTelefono, string StrEmail, int IdRolEmpleado, DateTime DtmIngreso, DateTime DtmRetiro, string strDatosAdicionales, DateTime DtmFechaModifica, string StrUsuarioModifico, bool Activo)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_INSERTAR_EMPLEADO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@strNombre", strNombre);
            comando.Parameters.AddWithValue("@NumDocumento", NumDocumento);
            comando.Parameters.AddWithValue("@StrDireccion", StrDireccion);
            comando.Parameters.AddWithValue("@StrTelefono", StrTelefono);
            comando.Parameters.AddWithValue("@StrEmail", StrEmail);
            comando.Parameters.AddWithValue("@IdRolEmpleado", IdRolEmpleado); // Corregido: parámetro faltante
            comando.Parameters.AddWithValue("@DtmIngreso", DtmIngreso);
            comando.Parameters.AddWithValue("@DtmRetiro", DtmRetiro);
            comando.Parameters.AddWithValue("@strDatosAdicionales", strDatosAdicionales);
            comando.Parameters.AddWithValue("@DtmFechaModifica", DtmFechaModifica);
            comando.Parameters.AddWithValue("@StrUsuarioModifico", StrUsuarioModifico);
            comando.Parameters.AddWithValue("@Activo", Activo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable ReadAllEmpleado()
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_SELECCIONAR_EMPLEADOS_ACTIVOS";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);
            conexion.CloseConnection();
            return table;
        }

        /// <param name="IdEmpleado">parámetro de entrada para eliminar el registro de acuerdo al filtro id</param>
        public void DeleteEmpleado(int IdEmpleado)
                {
                    comando.Connection = conexion.OpenConnection();
                    comando.CommandText = "SP_ELIMINAR_USUARIO";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);

                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
      




    }
}
