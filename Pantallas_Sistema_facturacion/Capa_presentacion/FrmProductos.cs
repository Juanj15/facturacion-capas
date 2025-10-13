using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;

namespace FrmCategoria
{
    public partial class FrmProductos : Form
    {
        private readonly NEGProducto _negocio = new NEGProducto();

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
            try
            {
                DataTable productos = _negocio.ObtenerProductos(filtro);

                DGProductos.Rows.Clear();

                foreach (DataRow row in productos.Rows)
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
            Close();
        }

        private void DGProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar clics fuera de las filas válidas
            if (e.RowIndex < 0) return;

            string strCodigo = DGProductos.Rows[e.RowIndex].Cells["StrCodigo"].Value?.ToString();

            if (string.IsNullOrEmpty(strCodigo)) return;

            // Editar producto
            if (e.ColumnIndex == DGProductos.Columns["BtnEditar"].Index)
            {
                FrmInsertarProductos frm = new FrmInsertarProductos();
                frm.Id_Producto = strCodigo;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarProductos();
                }
            }

            // Eliminar producto
            if (e.ColumnIndex == DGProductos.Columns["BtnEliminar"].Index)
            {
                var result = MessageBox.Show(
                    $"¿Está seguro de eliminar el producto con código {strCodigo}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (_negocio.EliminarProducto(strCodigo, out string error))
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar producto: " + error,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmInsertarProductos frm = new FrmInsertarProductos();
            frm.Id_Producto = string.Empty;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }
    }
}
