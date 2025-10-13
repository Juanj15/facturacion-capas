using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class ProductoDAO
    {
        private readonly string _connStr = AppConfig.ConnString;

        public DataTable ObtenerProductos(string filtro = "")
        {
            string query = "SELECT StrCodigo, StrNombre, IdCategoria, NumPrecioVenta, NumStock FROM TBLPRODUCTO";

            if (!string.IsNullOrEmpty(filtro))
                query += " WHERE StrNombre LIKE @Filtro";

            using (var conn = new SqlConnection(_connStr))
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

        public DataRow ObtenerProductoPorCodigo(string codigo)
        {
            string query = @"SELECT StrCodigo, StrNombre, IdCategoria, NumPrecioVenta, NumStock 
                             FROM TBLPRODUCTO WHERE StrCodigo = @StrCodigo";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StrCodigo", codigo);

                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0) return null;
                    return dt.Rows[0];
                }
            }
        }

        // Aquí cambia: idCategoria es int
        public void InsertarProducto(string codigo, string nombre, int idCategoria, decimal precio, int stock)
        {
            string query = @"INSERT INTO TBLPRODUCTO (StrCodigo, StrNombre, IdCategoria, NumPrecioVenta, NumStock)
                             VALUES (@StrCodigo, @StrNombre, @IdCategoria, @NumPrecioVenta, @NumStock)";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StrCodigo", codigo);
                cmd.Parameters.AddWithValue("@StrNombre", nombre);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria); 
                cmd.Parameters.AddWithValue("@NumPrecioVenta", precio);
                cmd.Parameters.AddWithValue("@NumStock", stock);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Aquí cambia: idCategoria es int
        public void ActualizarProducto(string codigo, string nombre, int idCategoria, decimal precio, int stock)
        {
            string query = @"UPDATE TBLPRODUCTO 
                             SET StrNombre = @StrNombre, IdCategoria = @IdCategoria, 
                                 NumPrecioVenta = @NumPrecioVenta, NumStock = @NumStock
                             WHERE StrCodigo = @StrCodigo";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StrCodigo", codigo);
                cmd.Parameters.AddWithValue("@StrNombre", nombre);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria); 
                cmd.Parameters.AddWithValue("@NumPrecioVenta", precio);
                cmd.Parameters.AddWithValue("@NumStock", stock);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(string codigo)
        {
            string query = "DELETE FROM TBLPRODUCTO WHERE StrCodigo = @StrCodigo";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StrCodigo", codigo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

