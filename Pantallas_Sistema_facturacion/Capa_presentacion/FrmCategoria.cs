using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;

namespace FrmCategoria
{
    public partial class FrmCategorias : Form
    {
        private readonly NEGCategoria _negocio = new NEGCategoria();

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias(string filtro = "")
        {
            try
            {
                DataTable categorias = _negocio.ObtenerCategorias(filtro);

                DGCategoria.Rows.Clear();

                foreach (DataRow row in categorias.Rows)
                {
                    DGCategoria.Rows.Add(
                        row["IdCategoria"],
                        row["StrDescripcion"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias(TxtBuscar.Text.Trim());
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarCategoria frm = new FrmInsertarCategoria();
            frm.Id_Categoria = 0;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarCategorias();
            }
        }

        private void DGCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGCategoria.Columns["BtnEditar"].Index)
            {
                var cell = DGCategoria.Rows[e.RowIndex].Cells["IdCategoria"].Value;
                if (cell == null) { MessageBox.Show("No se encontró IdCategoria en la fila."); return; }

                int idCategoria = Convert.ToInt32(cell);

                // Usa el constructor con ID (ver paso 2)
                using (var frm = new FrmInsertarCategoria(idCategoria))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        CargarCategorias();
                }
            }

            // Eliminar categoría
            if (e.ColumnIndex == DGCategoria.Columns["BtnEliminar"].Index)
            {
                if (DGCategoria.Rows[e.RowIndex].Cells["IdCategoria"].Value == null)
                {
                    MessageBox.Show("No se pudo obtener el ID de la categoría seleccionada.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCategoria = Convert.ToInt32(DGCategoria.Rows[e.RowIndex].Cells["IdCategoria"].Value);

                var confirmacion = MessageBox.Show($"¿Está seguro de eliminar la categoría con ID {idCategoria}?",
                                                   "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    if (_negocio.EliminarCategoria(idCategoria, out string error))
                    {
                        MessageBox.Show("Categoría eliminada correctamente.",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategorias(); // 🔁 Actualiza la vista
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + error,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

