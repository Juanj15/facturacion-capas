using Capa_Negocio;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace FrmCategoria
{
    public partial class FrmClientes : Form
    {
        private readonly NEGClientes negocioClientes = new NEGClientes();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que sea una fila válida
            if (e.RowIndex < 0) return;

            // Opción para editar cliente
            if (e.ColumnIndex == DGClientes.Columns["BtnEditar"].Index)
            {
                var cellValue = DGClientes.Rows[e.RowIndex].Cells["IdCliente"].Value;
                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("El ID del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCliente = Convert.ToInt32(cellValue);

                FrmInsertarClientes clienteForm = new FrmInsertarClientes
                {
                    IdCliente = idCliente
                };

                var result = clienteForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    llenar_grid();
                }
            }

            // Opción para eliminar cliente
            if (e.ColumnIndex == DGClientes.Columns["BtnEliminar"].Index)
            {
                var cellValue = DGClientes.Rows[e.RowIndex].Cells["IdCliente"].Value;
                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("El ID del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCliente = Convert.ToInt32(cellValue);

                var confirm = MessageBox.Show(
                    $"¿Desea eliminar al cliente con ID {idCliente}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        negocioClientes.Delete(idCliente, Environment.UserName);
                        MessageBox.Show($"Cliente con ID {idCliente} eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenar_grid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmInsertarClientes clienteForm = new FrmInsertarClientes
            {
                IdCliente = 0
            };

            var result = clienteForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenar_grid();
            }
        }

        public void llenar_grid()
        {
            try
            {
                DataTable dt = negocioClientes.View();
                DGClientes.AutoGenerateColumns = true;
                DGClientes.DataSource = dt;
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxcliente_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxcliente.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                llenar_grid();
                return;
            }
            // Filtro directo sobre el DataTable ya cargado
            DataTable dt = (DataTable)DGClientes.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"StrNombre LIKE '%{filtro}%' OR Convert(NumDocumento, 'System.String') LIKE '%{filtro}%'";
            }
        }
    }
}
