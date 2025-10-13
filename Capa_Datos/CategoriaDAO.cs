using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class CategoriaDAO
    {
        // Cadena de conexión a la base de datos
        private readonly string connStr = AppConfig.ConnString;

        // Obtener todas las categorías (con opción de filtro)
        public DataTable ObtenerCategorias(string filtro = "")
        {
            string query = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";

            if (!string.IsNullOrEmpty(filtro))
                query += " WHERE StrDescripcion LIKE @Filtro";

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(filtro))
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Obtener una categoría por su ID
        public DataRow ObtenerCategoriaPorId(int id)
        {
            string query = "SELECT * FROM TBLCATEGORIA_PROD WHERE IdCategoria = @IdCategoria";

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCategoria", id);

                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                }
            }
        }

        // Insertar una nueva categoría
        public void InsertarCategoria(string descripcion)
        {
            string query = "INSERT INTO TBLCATEGORIA_PROD (StrDescripcion) VALUES (@StrDescripcion)";

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StrDescripcion", descripcion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar una categoría existente
        public void ActualizarCategoria(int id, string descripcion)
        {
            string query = @"UPDATE TBLCATEGORIA_PROD
                             SET StrDescripcion = @StrDescripcion
                             WHERE IdCategoria = @IdCategoria";

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCategoria", id);
                cmd.Parameters.AddWithValue("@StrDescripcion", descripcion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar una categoría por su ID
        public void EliminarCategoria(int id)
        {
            string query = "DELETE FROM TBLCATEGORIA_PROD WHERE IdCategoria = @IdCategoria";

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCategoria", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
