using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public class UsuarioSeguridad
    {
        public int IdSeguridad { get; set; }
        public int IdEmpleado { get; set; }
        public string StrUsuario { get; set; } = "";
        public string StrClave { get; set; } = "";
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifico { get; set; } = "";
    }

    public static class UsuarioDAO
    {
        private static readonly string cs = AppConfig.ConnString;

        // Busca un usuario por ID de empleado
        public static UsuarioSeguridad? BuscarPorEmpleadoId(int idEmpleado)
        {
            using var conn = new SqlConnection(cs);
            using var cmd = new SqlCommand(@"
                SELECT IdSeguridad, IdEmpleado, StrUsuario, StrClave, DtmFechaModifica, StrUsuarioModifico
                FROM dbo.TBLSEGURIDAD
                WHERE IdEmpleado = @id", conn);

            cmd.Parameters.AddWithValue("@id", idEmpleado);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return new UsuarioSeguridad
            {
                IdSeguridad = reader["IdSeguridad"] != DBNull.Value ? Convert.ToInt32(reader["IdSeguridad"]) : 0,
                IdEmpleado = reader["IdEmpleado"] != DBNull.Value ? Convert.ToInt32(reader["IdEmpleado"]) : 0,
                StrUsuario = reader["StrUsuario"]?.ToString() ?? "",
                StrClave = reader["StrClave"]?.ToString() ?? "",
                DtmFechaModifica = reader["DtmFechaModifica"] != DBNull.Value ? Convert.ToDateTime(reader["DtmFechaModifica"]) : DateTime.MinValue,
                StrUsuarioModifico = reader["StrUsuarioModifico"]?.ToString() ?? ""
            };
        }

        // Guarda o actualiza un usuario
        public static bool Guardar(int idEmpleado, string username, string password, out string error)
        {
            error = "";

            using var conn = new SqlConnection(cs);
            using var cmd = new SqlCommand("upsert_Usuario", conn); // SP debe aceptar los nuevos campos
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            cmd.Parameters.AddWithValue("@StrUsuario", username);
            cmd.Parameters.AddWithValue("@StrClave", password);
            cmd.Parameters.AddWithValue("@DtmFechaModifica", DateTime.Now);
            cmd.Parameters.AddWithValue("@StrUsuarioModifico", Environment.UserName);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation
                    error = "El nombre de usuario ya está en uso.";
                else
                    error = "Error guardando usuario: " + ex.Message;
                return false;
            }
        }
    }
}


