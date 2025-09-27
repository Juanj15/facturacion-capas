using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCategoria
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        public void llenar_grid(string filtro = "")
        {
            string connStr = AppConfig.ConnString;
            string query = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE StrDescripcion LIKE @Filtro";
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

                DGCategoria.Rows.Clear();

                foreach (DataRow row in dt.Rows)
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

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void labelproductos_Click(object sender, EventArgs e)
        {
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            llenar_grid(TxtBuscar.Text.Trim());
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarCategoria Categoria = new FrmInsertarCategoria();
            Categoria.Id_Categoria = 0;
            if (Categoria.ShowDialog() == DialogResult.OK)
            {
                llenar_grid();
            }
        }

        private void DGCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGCategoria.Columns["BtnEditar"].Index && e.RowIndex >= 0)
            {
                int IdCategoria = Convert.ToInt32(DGCategoria.Rows[e.RowIndex].Cells["IdCategoria"].Value);
                FrmInsertarCategoria Categoria = new FrmInsertarCategoria();
                Categoria.Id_Categoria = IdCategoria;

                if (Categoria.ShowDialog() == DialogResult.OK)
                {
                    llenar_grid();
                }
            }
            if (e.ColumnIndex == DGCategoria.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                int IdCategoria = Convert.ToInt32(DGCategoria.Rows[e.RowIndex].Cells["IdCategoria"].Value);
                var result = MessageBox.Show($"¿Está seguro de eliminar la categoría con ID {IdCategoria}?",
                                             "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EliminarCategoria(IdCategoria);
                    llenar_grid();
                }
            }
        }

        private void EliminarCategoria(int id_categoria)
        {
            string connStr = AppConfig.ConnString;
            string query = "DELETE FROM TBLCATEGORIA_PROD WHERE IdCategoria = @IdCategoria";

            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCategoria", id_categoria);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar categoría: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevaCaegoria_Click(object sender, EventArgs e)
        {
            FrmInsertarCategoria frminsertarcategoria = new FrmInsertarCategoria();
            frminsertarcategoria.Id_Categoria = 0;

            if (frminsertarcategoria.ShowDialog() == DialogResult.OK)
            {
                llenar_grid();
            }
        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            llenar_grid(TxtBuscar.Text.Trim());
        }
    }
}

