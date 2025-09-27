using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrmCategoria
{
    public partial class FrmInsertarProductos : Form
    {
        public FrmInsertarProductos()
        {
            InitializeComponent();
        }

        public string Id_Producto { get; set; } 

        private void FrmInsertarProductos_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_Producto))
            {
                LblTituloProducto.Text = "Nuevo Producto";
            }
            else
            {
                LblTituloProducto.Text = "Editar Producto";
                CargarProducto(Id_Producto);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_Producto))
            {
                InsertarProducto();
            }
            else
            {
                ActualizarProducto(Id_Producto);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarProducto(string codigo)
        {
            string connStr = AppConfig.ConnString;
            string query = @"SELECT StrCodigo, StrNombre, IdCategoria, NumPrecioVenta, NumStock 
                             FROM TBLPRODUCTO WHERE StrCodigo = @StrCodigo";

            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StrCodigo", codigo);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    TxtReferencia.Text = rdr["StrCodigo"]?.ToString() ?? "";
                    TxtNombre.Text = rdr["StrNombre"]?.ToString() ?? "";
                    ComboxCategoria.Text = rdr["IdCategoria"]?.ToString() ?? "";
                    TxtVenta.Text = rdr["NumPrecioVenta"]?.ToString() ?? "";
                    TxtStock.Text = rdr["NumStock"]?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar producto: " + ex.Message);
            }
        }

        private void InsertarProducto()
        {
            string connStr = AppConfig.ConnString;
            string query = @"INSERT INTO TBLPRODUCTO (StrCodigo, StrNombre, IdCategoria, NumPrecioVenta, NumStock) 
                             VALUES (@StrCodigo, @StrNombre, @IdCategoria, @NumPrecioVenta, @NumStock)";

            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StrCodigo", TxtReferencia.Text.Trim());
                cmd.Parameters.AddWithValue("@StrNombre", TxtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@IdCategoria", ComboxCategoria.Text.Trim());
                cmd.Parameters.AddWithValue("@NumPrecioVenta", decimal.Parse(TxtVenta.Text));
                cmd.Parameters.AddWithValue("@NumStock", int.Parse(TxtStock.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar producto: " + ex.Message);
            }
        }

        private void ActualizarProducto(string codigo)
        {
            string connStr = AppConfig.ConnString;
            string query = @"UPDATE TBLPRODUCTO 
                             SET StrNombre=@StrNombre, IdCategoria=@IdCategoria, 
                                 NumPrecioVenta=@NumPrecioVenta, NumStock=@NumStock
                             WHERE StrCodigo=@StrCodigo";

            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StrCodigo", codigo);
                cmd.Parameters.AddWithValue("@StrNombre", TxtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@IdCategoria", ComboxCategoria.Text.Trim());
                cmd.Parameters.AddWithValue("@NumPrecioVenta", decimal.Parse(TxtVenta.Text));
                cmd.Parameters.AddWithValue("@NumStock", int.Parse(TxtStock.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
        }
    }
}
