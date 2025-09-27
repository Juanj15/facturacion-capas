using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public static class EmpleadoDAO
    {
        private static readonly string connectionString = AppConfig.ConnString;

        // Listar todos los empleados (con nombre de rol)
        public static List<Empleado> ObtenerTodos()
        {
            var lista = new List<Empleado>();

            using SqlConnection conn = new SqlConnection(connectionString);
        
            string query = @"
            SELECT e.IdEmpleado, e.strNombre, e.NumDocumento, e.StrTelefono, e.StrEmail,
                   e.StrDireccion, e.IdRolEmpleado, r.NombreRol
            FROM dbo.TBLEMPLEADO e
            LEFT JOIN dbo.TBLROLES r ON e.IdRolEmpleado = r.IdRolEmpleado
            WHERE e.Activo = 1
            ORDER BY e.strNombre";

            using SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Empleado
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Documento = reader["NumDocumento"]?.ToString() ?? "",
                    Telefono = reader["StrTelefono"]?.ToString() ?? "",
                    Correo = reader["StrEmail"]?.ToString() ?? "",
                    Direccion = reader["StrDireccion"]?.ToString() ?? "",
                    IdRolEmpleado = reader["IdRolEmpleado"] == DBNull.Value ? null : (int?)reader["IdRolEmpleado"],
                    NombreRol = reader["NombreRol"]?.ToString() ?? ""
                });
            }
            return lista;
        }

        // Guardar (insertar o actualizar) un empleado
        public static void Guardar(Empleado emp, string usuarioModifica)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("actualizar_Empleado", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdEmpleado", emp.Id);
            cmd.Parameters.AddWithValue("@strNombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@NumDocumento", long.Parse(emp.Documento));
            cmd.Parameters.AddWithValue("@StrDireccion", emp.Direccion ?? "");
            cmd.Parameters.AddWithValue("@StrTelefono", emp.Telefono ?? "");
            cmd.Parameters.AddWithValue("@StrEmail", emp.Correo ?? "");
            cmd.Parameters.AddWithValue("@IdRolEmpleado", emp.IdRolEmpleado ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DtmIngreso", DateTime.Now);
            cmd.Parameters.AddWithValue("@DtmRetiro", new DateTime(1900, 1, 1)); // Por ahora fijo
            cmd.Parameters.AddWithValue("@strDatosAdicionales", "");
            cmd.Parameters.AddWithValue("@DtmFechaModifica", DateTime.Now);
            cmd.Parameters.AddWithValue("@StrUsuarioModifico", Environment.UserName);


            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // Eliminar empleado
        public static bool Eliminar(int idEmpleado)
        {
            using SqlConnection conn = new SqlConnection(AppConfig.ConnString);
            using SqlCommand cmd = new SqlCommand(@"
            UPDATE dbo.TBLEMPLEADO
            SET Activo = 0
            WHERE IdEmpleado = @IdEmpleado", conn);


            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
    }
}

