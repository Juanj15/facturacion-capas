using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DATEmpleados
    {
        private DATConexion conexion = new DATConexion();

        //SqlDataReader dataReader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// Método para Select  Empleados
        public DataTable SelectEmpleados()
        {
            DataTable table = new DataTable();
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_ObtenerEmpleadosActivos";
                comando.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    table.Load(dataReader);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al consultar empleados: " + ex.Message, ex);
            }
            finally
            {
                conexion.CloseConnection();
            }
            return table;
        }

        /// Método para Insertar nuevo Empleados
        public void InsertEmpleado(string strNombre, long NumDocumento, string StrDireccion, string StrTelefono, string StrEmail, string NombreRol, string StrUsuarioModifico)
        {
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_InsertarEmpleados";
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros enviados al SP
                comando.Parameters.AddWithValue("@strNombre", strNombre);
                comando.Parameters.AddWithValue("@NumDocumento", NumDocumento);
                comando.Parameters.AddWithValue("@StrDireccion", StrDireccion);
                comando.Parameters.AddWithValue("@StrTelefono", StrTelefono);
                comando.Parameters.AddWithValue("@StrEmail", StrEmail);
                comando.Parameters.AddWithValue("@NombreRol", NombreRol);
                comando.Parameters.AddWithValue("@StrUsuarioModifico", StrUsuarioModifico);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar empleado: " + ex.Message, ex);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.CloseConnection();
            }
        }

        /// <summary>
        /// Actualiza los datos de un empleado existente en la base de datos.
        /// </summary>
        /// <param name="IdEmpleado">Id del empleado a actualizar</param>
        /// <param name="StrNombre">Nombre del empleado</param>
        /// <param name="NumDocumento">Documento de identificación</param>
        /// <param name="StrTelefono">Teléfono</param>
        /// <param name="StrEmail">Correo electrónico</param>
        /// <param name="StrDireccion">Dirección</param>
        /// <param name="NombreRol">Nombre del rol asociado</param>
        /// <param name="StrUsuarioModifico">Usuario que realiza la actualización</param>
        public void UpdateEmpleado(
            int IdEmpleado,
            string StrNombre,
            long NumDocumento,
            string StrTelefono,
            string StrEmail,
            string StrDireccion,
            string NombreRol,
            string StrUsuarioModifico)
        {
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_ActualizarEmpleados";
                comando.CommandType = CommandType.StoredProcedure;

                // Pasar parámetros al procedimiento almacenado
                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@strNombre", StrNombre);
                comando.Parameters.AddWithValue("@NumDocumento", NumDocumento);
                comando.Parameters.AddWithValue("@StrTelefono", StrTelefono);
                comando.Parameters.AddWithValue("@StrEmail", StrEmail);
                comando.Parameters.AddWithValue("@StrDireccion", StrDireccion);
                comando.Parameters.AddWithValue("@NombreRol", NombreRol);
                comando.Parameters.AddWithValue("@StrUsuarioModifico", StrUsuarioModifico);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Aquí capturas el RAISERROR de SQL y otros errores
                throw new Exception("Error al actualizar el empleado: " + ex.Message, ex);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.CloseConnection();
            }
        }

        /// <summary>
        /// Marca un empleado como inactivo (eliminación lógica).
        /// </summary>
        /// <param name="IdEmpleado">Id del empleado a modificar</param>
        /// <param name="StrUsuarioModifico">Usuario que realiza la modificación</param>
        public void DeleteEmpleado(int IdEmpleado, string StrUsuarioModifico)
        {
            try
            {
                comando.Connection = conexion.OpenConnection();
                comando.CommandText = "SP_EliminarEmpleados";  // Nombre correcto del SP
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@StrUsuarioModifico", StrUsuarioModifico);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar empleado: " + ex.Message, ex);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.CloseConnection();
            }
        }
    }
}
