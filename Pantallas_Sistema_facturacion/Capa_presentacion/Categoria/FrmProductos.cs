using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrmCategoria
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos(string filtro = "")
        {
            string connStr = AppConfig.ConnString;
            string query = "SELECT StrCodigo, StrNombre, IdCategoria, NumPrecioVenta, NumStock FROM TBLPRODUCTO";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE StrNombre LIKE @Filtro";
            }

            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(filtro))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                }

                using var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                DGProductos.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    DGProductos.Rows.Add(
                        row["StrCodigo"].ToString(),
                        row["StrNombre"].ToString(),
                        row["IdCategoria"].ToString(),
                        row["NumPrecioVenta"].ToString(),
                        row["NumStock"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(TxtBuscar.Text.Trim());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Editar producto
            if (e.ColumnIndex == DGProductos.Columns["BtnEditar"].Index && e.RowIndex >= 0)
            {
                string strCodigo = DGProductos.Rows[e.RowIndex].Cells["StrCodigo"].Value?.ToString();

                if (!string.IsNullOrEmpty(strCodigo))
                {
                    FrmInsertarProductos Producto = new FrmInsertarProductos();
                    Producto.Id_Producto = strCodigo;

                    if (Producto.ShowDialog() == DialogResult.OK)
                    {
                        CargarProductos();
                    }
                }
            }

            // Eliminar producto
            if (e.ColumnIndex == DGProductos.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                string strCodigo = DGProductos.Rows[e.RowIndex].Cells["StrCodigo"].Value?.ToString();

                if (!string.IsNullOrEmpty(strCodigo))
                {
                    var result = MessageBox.Show($"¿Está seguro de eliminar el producto con StrCodigo {strCodigo}?",
                                                 "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        EliminarProducto(strCodigo);
                        CargarProductos();
                    }
                }
            }
        }

        private void EliminarProducto(string strCodigo)
        {
            string connStr = AppConfig.ConnString;
            string query = "DELETE FROM TBLPRODUCTO WHERE StrCodigo = @StrCodigo";

            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StrCodigo", strCodigo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarProductos Producto = new FrmInsertarProductos();
            Producto.Id_Producto = string.Empty;

            if (Producto.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmInsertarProductos frminsertarproducto = new FrmInsertarProductos();
            frminsertarproducto.Id_Producto = string.Empty;

            if (frminsertarproducto.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {

            CargarProductos(TxtBuscar.Text.Trim());
        }
    }
}
