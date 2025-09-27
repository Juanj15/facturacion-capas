using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FrmCategoria
{
    public partial class FrmInsertarClientes : Form
    {

        public FrmInsertarClientes()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }

        private void FrmInsertarClientes_Load(object sender, EventArgs e)
        {
            // Codigo para si el IdCliente es = 0, el label cambiara por "Nuevo Cliente", si no, "Editar Cliente"
            if (IdCliente == 0)
            {
                LblTituloCliente.Text = "Nuevo Cliente";
            }
            else
            {
                LblTituloCliente.Text = "Editar Cliente";
                TxTId_Cliente.Text = IdCliente.ToString();
                CargarCliente(IdCliente);
            }
        }

        private void CargarCliente(int id)
        {
            // Codigo para cargar los datos del cliente desde la base de datos TBLCLIENTES si el idcliente es diferente de 0
            string connStr = AppConfig.ConnString;
            string query = @"
                SELECT StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM TBLCLIENTES WHERE IdCliente = @IdCliente";
            try
            {
                using var conn = new SqlConnection(connStr);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCliente", id);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    TxtNombre.Text = rdr["StrNombre"]?.ToString() ?? "";
                    TxtDocumento.Text = rdr["NumDocumento"]?.ToString() ?? "";
                    TxtDireccion.Text = rdr["StrDireccion"]?.ToString() ?? "";
                    TxtTelefono.Text = rdr["StrTelefono"]?.ToString() ?? "";
                    TxtEmail.Text = rdr["StrEmail"]?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Codigo donde validara que el campo nombre no este vacio, de lo contrario mostrara un mensaje de advertencia
            var nombre = TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var documento = TxtDocumento.Text.Trim();
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("El documento es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var numDocumento = TxtDocumento.Text.Trim();
            var direccion = TxtDireccion.Text.Trim();
            var telefono = TxtTelefono.Text.Trim();
            var email = TxtEmail.Text.Trim();
            var usuario = Environment.UserName ?? "system";
            var fechaMod = DateTime.Now;

            string connStr = AppConfig.ConnString;

            try
            {
                using var conn = new SqlConnection(connStr);
                conn.Open();

                if (IdCliente == 0)
                {
                    // Si el IdCliente es 0, entonces insertara a la base de datos TBLCLIENTES un nuevo cliente.
                    string insertSql = @"
                        INSERT INTO TBLCLIENTES
                            (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, DtmFechaModifica, StrUsuarioModifica)
                        VALUES
                            (@StrNombre, @NumDocumento, @StrDireccion, @StrTelefono, @StrEmail, @DtmFechaModifica, @StrUsuarioModifica);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using var cmd = new SqlCommand(insertSql, conn);
                    cmd.Parameters.AddWithValue("@StrNombre", nombre);
                    cmd.Parameters.AddWithValue("@NumDocumento", (object)numDocumento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StrDireccion", (object)direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StrTelefono", (object)telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StrEmail", (object)email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DtmFechaModifica", fechaMod);
                    cmd.Parameters.AddWithValue("@StrUsuarioModifica", usuario);

                    var newIdObj = cmd.ExecuteScalar();
                    if (newIdObj != null && int.TryParse(newIdObj.ToString(), out int newId))
                    {
                        TxTId_Cliente.Text = newId.ToString();
                    }

                    MessageBox.Show("Cliente agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si el IdCliente es diferente que 0, entonces editara a la base de datos TBLCLIENTES el cliente.
                    string updateSql = @"
                        UPDATE TBLCLIENTES
                        SET StrNombre = @StrNombre,
                            NumDocumento = @NumDocumento,
                            StrDireccion = @StrDireccion,
                            StrTelefono = @StrTelefono,
                            StrEmail = @StrEmail,
                            DtmFechaModifica = @DtmFechaModifica,
                            StrUsuarioModifica = @StrUsuarioModifica
                        WHERE IdCliente = @IdCliente;";

                    using var cmd = new SqlCommand(updateSql, conn);
                    cmd.Parameters.AddWithValue("@StrNombre", nombre);
                    cmd.Parameters.AddWithValue("@NumDocumento", (object)numDocumento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StrDireccion", (object)direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StrTelefono", (object)telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StrEmail", (object)email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DtmFechaModifica", fechaMod);
                    cmd.Parameters.AddWithValue("@StrUsuarioModifica", usuario);
                    cmd.Parameters.AddWithValue("@IdCliente", IdCliente);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Cliente actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se encontró el cliente para actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Acualiza el dtgclientes en FrmClientes
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
