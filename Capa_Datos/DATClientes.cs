using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class DATClientes
    {
        private DATConexion conexion = new DATConexion();

        SqlDataReader dataReader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();


        /// Método para Select  Clientes
        public DataTable SelectClientesActivos()
        {
            DataTable table = new DataTable();
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_ObtenerClientesActivos";
                comando.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    table.Load(dataReader);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al consultar clientes: " + ex.Message, ex);
            }
            finally
            {
                conexion.CloseConnection();
            }

            return table;
        }

        /// <summary>
        /// Método para insertar un nuevo cliente en la base de datos
        /// </summary>
        public void InsertCliente(string strNombre, long numDocumento, string strDireccion, string strTelefono, string strEmail, string strUsuarioModifica)
        {
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_InsertarCliente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@StrNombre", strNombre);
                comando.Parameters.AddWithValue("@NumDocumento", numDocumento);
                comando.Parameters.AddWithValue("@StrDireccion", strDireccion);
                comando.Parameters.AddWithValue("@StrTelefono", strTelefono);
                comando.Parameters.AddWithValue("@StrEmail", strEmail);
                comando.Parameters.AddWithValue("@StrUsuarioModifica", strUsuarioModifica);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message, ex);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.CloseConnection();
            }
        }

        /// <summary>
        /// Actualiza los datos de un cliente existente en la base de datos.
        /// </summary>
        /// <param name="IdCliente">Id del cliente a actualizar</param>
        /// <param name="StrNombre">Nombre del cliente</param>
        /// <param name="NumDocumento">Documento de identificación</param>
        /// <param name="StrTelefono">Teléfono</param>
        /// <param name="StrEmail">Correo electrónico</param>
        /// <param name="StrDireccion">Dirección</param>
        /// <param name="StrUsuarioModifica">Usuario que realiza la actualización</param>
        public void UpdateCliente(
            int IdCliente,
            string StrNombre,
            long NumDocumento,
            string StrTelefono,
            string StrEmail,
            string StrDireccion,
            string StrUsuarioModifica)
        {
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_ActualizarCliente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdCliente", IdCliente);
                comando.Parameters.AddWithValue("@StrNombre", StrNombre);
                comando.Parameters.AddWithValue("@NumDocumento", NumDocumento);
                comando.Parameters.AddWithValue("@StrTelefono", StrTelefono);
                comando.Parameters.AddWithValue("@StrEmail", StrEmail);
                comando.Parameters.AddWithValue("@StrDireccion", StrDireccion);
                comando.Parameters.AddWithValue("@StrUsuarioModifica", StrUsuarioModifica);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message, ex);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.CloseConnection();
            }
        }

        /// <summary>
        /// Marca un cliente como inactivo (eliminación lógica).
        /// </summary>
        /// <param name="IdCliente">Id del cliente a modificar</param>
        /// <param name="StrUsuarioModifica">Usuario que realiza la modificación</param>
        public void DeleteCliente(int IdCliente, string StrUsuarioModifica)
        {
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_EliminarCliente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdCliente", IdCliente);
                comando.Parameters.AddWithValue("@StrUsuarioModifica", StrUsuarioModifica);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message, ex);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.CloseConnection();
            }
        }
    }
}
