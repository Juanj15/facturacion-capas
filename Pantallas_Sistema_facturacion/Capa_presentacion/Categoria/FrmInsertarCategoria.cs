using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace FrmCategoria
{
    public partial class FrmInsertarCategoria : Form
    {
        public FrmInsertarCategoria()
        {
            InitializeComponent();
        }

        public int Id_Categoria { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Id_Categoria == 0)
            {
                LblTituloCategoria.Text = "Nueva Categoria";
            }
            else
            {
                LblTituloCategoria.Text = "Editar Categoria";
                CargarCategoria();
            }
        }

        private void CargarCategoria()
        {
            string connStr = AppConfig.ConnString;
            string query = @"SELECT IdCategoria, StrDescripcion 
                             FROM TBLCATEGORIA_PROD 
                             WHERE IdCategoria = @IdCategoria";
            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCategoria", Id_Categoria);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    TxTId_Categoria.Text = rdr["IdCategoria"]?.ToString() ?? "";
                    TxtDescripcion.Text = rdr["StrDescripcion"]?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categoría: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string connStr = AppConfig.ConnString;
            string query;

            if (Id_Categoria == 0)
            {
                query = "INSERT INTO TBLCATEGORIA_PROD (StrDescripcion) VALUES (@Descripcion)";
            }
            else
            {
                query = "UPDATE TBLCATEGORIA_PROD SET StrDescripcion = @Descripcion WHERE IdCategoria = @IdCategoria";
            }

            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text.Trim());

                if (Id_Categoria != 0)
                    cmd.Parameters.AddWithValue("@IdCategoria", Id_Categoria);

                conn.Open();
                cmd.ExecuteNonQuery();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar categoría: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxTId_Categoria_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
