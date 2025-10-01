using Capa_Negocio;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrmCategoria
{
    public partial class FrmInsertarClientes : Form
    {
        private readonly NEGClientes negocioClientes = new NEGClientes();

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
            try
            {
                DataTable clientes = negocioClientes.View();
                DataRow[] cliente = clientes.Select($"IdCliente = {id}");

                if (cliente.Length > 0)
                {
                    TxtNombre.Text = cliente[0]["StrNombre"].ToString();
                    TxtDocumento.Text = cliente[0]["NumDocumento"].ToString();
                    TxtDireccion.Text = cliente[0]["StrDireccion"].ToString();
                    TxtTelefono.Text = cliente[0]["StrTelefono"].ToString();
                    TxtEmail.Text = cliente[0]["StrEmail"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
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
            var nombre = TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TxtDocumento.Text.Trim()))
            {
                MessageBox.Show("El documento es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                long numDocumento = Convert.ToInt64(TxtDocumento.Text.Trim());
                string direccion = TxtDireccion.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                string email = TxtEmail.Text.Trim();
                string usuario = Environment.UserName ?? "system";

                if (IdCliente == 0)
                {
                    // ✅ Crear nuevo cliente
                    negocioClientes.Create(nombre, numDocumento, direccion, telefono, email, usuario);
                    MessageBox.Show("Cliente agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // ✅ Actualizar cliente existente
                    negocioClientes.Update(IdCliente, nombre, numDocumento, telefono, email, direccion, usuario);
                    MessageBox.Show("Cliente actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
