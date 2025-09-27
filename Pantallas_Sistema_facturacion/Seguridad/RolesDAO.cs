using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    // Cambia el nombre de la clase para evitar la colisión
    public sealed class RolInfoDAO
    {
        public int Id { get; set; }
        public string NombreRol { get; set; } = "";   // no null
        public string DescripcionRol { get; set; } = ""; // no null
    }

    public sealed class RolItem   // para combos (Id/Nombre)
    {
        public int Id { get; set; }
        public string NombreRol { get; set; } = "";
    }

    public static class RolesDAO
    {
        private static readonly string cs = AppConfig.ConnString;

        // Autocomplete (nombres)
        public static string[] ObtenerNombres()
        {
            var list = new List<string>();
            using var conn = new SqlConnection(cs);
            using var cmd = new SqlCommand(
                "SELECT NombreRol FROM dbo.TBLROLES ORDER BY NombreRol", conn);
            conn.Open();
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
                list.Add(rd.IsDBNull(0) ? "" : rd.GetString(0));
            return list.ToArray();
        }

        // Para ComboBox (Id/Nombre)
        public static List<RolItem> ObtenerParaCombo()
        {
            var list = new List<RolItem>();
            using var conn = new SqlConnection(cs);
            using var cmd = new SqlCommand(
                "SELECT IdRolEmpleado, NombreRol FROM dbo.TBLROLES ORDER BY NombreRol", conn);
            conn.Open();
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new RolItem
                {
                    Id = rd.GetInt32(0),
                    NombreRol = rd.IsDBNull(1) ? "" : rd.GetString(1)
                });
            }
            return list;
        }

        // Busca un rol por nombre
        public static RolInfoDAO? ObtenerPorNombre(string nombreRol)
        {
            using var conn = new SqlConnection(cs); // unificamos uso de cs
            using var cmd = new SqlCommand(@"
                SELECT IdRolEmpleado, NombreRol, ISNULL(DescripcionRol,'') AS DescripcionRol
                FROM dbo.TBLROLES
                WHERE NombreRol = @nombre", conn);

            cmd.Parameters.AddWithValue("@nombre", nombreRol);
            conn.Open();
            using var rd = cmd.ExecuteReader();
            if (!rd.Read()) return null;

            return new RolInfoDAO
            {
                Id = rd.GetInt32(0),
                NombreRol = rd.IsDBNull(1) ? "" : rd.GetString(1),
                DescripcionRol = rd.IsDBNull(2) ? "" : rd.GetString(2)
            };
        }

        // Crea si no existe por nombre
        public static RolInfoDAO GetOrCreate(string nombreRol)
        {
            var cur = ObtenerPorNombre(nombreRol);
            if (cur != null) return cur;

            using var conn = new SqlConnection(cs);
            using var cmd = new SqlCommand(@"
                INSERT INTO dbo.TBLROLES (NombreRol, DescripcionRol)
                VALUES (@nombre, @desc);
                SELECT SCOPE_IDENTITY();", conn);

            cmd.Parameters.AddWithValue("@nombre", nombreRol);
            cmd.Parameters.AddWithValue("@desc", ""); // inicia vacío
            conn.Open();
            int newId = Convert.ToInt32(cmd.ExecuteScalar());

            return new RolInfoDAO { Id = newId, NombreRol = nombreRol, DescripcionRol = "" };
        }

        // Actualiza solo la descripción por Id
        public static void ActualizarDescripcionRol(int idRol, string? descripcionRol)
        {
            using var conn = new SqlConnection(cs);
            using var cmd = new SqlCommand(@"
                UPDATE dbo.TBLROLES
                SET DescripcionRol = @d
                WHERE IdRolEmpleado = @id", conn); // <-- corregido WHERE

            // normaliza a cadena vacía si llega null
            cmd.Parameters.AddWithValue("@d", (object)(descripcionRol ?? ""));
            cmd.Parameters.AddWithValue("@id", idRol);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
