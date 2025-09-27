using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace FrmCategoria
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo para editar clientes desde el DataGridView
            if (e.ColumnIndex == DGClientes.Columns["BtnEditar"].Index && e.RowIndex >= 0)
            {
                var cellValue = DGClientes.Rows[e.RowIndex].Cells["IdCliente"].Value;
                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("El ID del cliente no es válido. ");
                    return;
                }
                int idcliente = Convert.ToInt32(cellValue);
                FrmInsertarClientes Cliente = new FrmInsertarClientes();
                Cliente.IdCliente = idcliente;
                var result = Cliente.ShowDialog();
                if (result == DialogResult.OK)
                {
                    llenar_grid();
                }
            }
            //codigo para eliminar un cliente al hacer clic en el botón "Eliminar" de la fila correspondiente
            if (e.ColumnIndex == DGClientes.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                var cellValue = DGClientes.Rows[e.RowIndex].Cells["IdCliente"].Value;
                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("El ID del cliente no es válido.");
                    return;
                }
                int idcliente = Convert.ToInt32(cellValue);
                var result = MessageBox.Show($"¿Desea eliminar al cliente con ID {idcliente}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string connectionString = AppConfig.ConnString;
                    try
                    {
                        // Baja lógica: marcar como inactivo (sin validar facturas asociadas)
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand("UPDATE TBLCLIENTES SET Activo = 0 WHERE IdCliente = @IdCliente", conn))
                        {
                            cmd.Parameters.AddWithValue("@IdCliente", idcliente);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Cliente con ID {idcliente} eliminado.");
                        llenar_grid(); // Refresca el grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al elimiar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FrmInsertarClientes Cliente = new FrmInsertarClientes();
            Cliente.IdCliente = 0;
            var result = Cliente.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenar_grid();
            }
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            //codigo para abrir el formulario FrmInsertarClientes en modo de inserción (IdCliente = 0)
            FrmInsertarClientes Cliente = new FrmInsertarClientes();
            Cliente.IdCliente = 0;
            var result = Cliente.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenar_grid();
            }
        }

        public void llenar_grid()
        {
            // Codigo para llenar el DataGridView con los datos de la tabla TBLCLIENTES
            string connectionString = AppConfig.ConnString;
            string query = @"
                SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, DtmFechaModifica, StrUsuarioModifica 
                FROM TBLCLIENTES
                WHERE Activo = 1;";

            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.Fill(dt);
                }

                DGClientes.AutoGenerateColumns = false;
                DGClientes.DataSource = dt;
                //codigo para ocultar las columnas que no se desean mostrar en el DataGridView
                foreach (DataGridViewColumn col in DGClientes.Columns)
                {
                    if (col.Name != "IdCliente" &&
                        col.Name != "StrNombre" &&
                        col.Name != "NumDocumento" &&
                        col.Name != "StrTelefono" &&
                        col.Name != "BtnEditar" &&
                        col.Name != "BtnEliminar")
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxcliente_TextChanged(object sender, EventArgs e)
        {
            //Codigo para buscar en el DataGridView los clientes que coincidan con el texto ingresado en el TextBox
            string filtro = textBoxcliente.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                llenar_grid();
                return;
            }

            string connectionString = AppConfig.ConnString;
            string query = @"
                SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, DtmFechaModifica, StrUsuarioModifica 
                FROM TBLCLIENTES 
                WHERE Activo = 1 AND (StrNombre LIKE @Filtro OR NumDocumento LIKE @Filtro);";

            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    conn.Open();
                    adapter.Fill(dt);
                }

                DGClientes.AutoGenerateColumns = false;
                DGClientes.DataSource = dt;

                foreach (DataGridViewColumn col in DGClientes.Columns)
                {
                    if (col.Name != "IdCliente" &&
                        col.Name != "StrNombre" &&
                        col.Name != "NumDocumento" &&
                        col.Name != "StrTelefono" &&
                        col.Name != "BtnEditar" &&
                        col.Name != "BtnEliminar")
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
