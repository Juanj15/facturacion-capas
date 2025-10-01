using Capa_Negocio;
using FrmCategoria;
using Microsoft.Data.SqlClient;  // ✅ La librería recomendada en .NET 8
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmEmpleados : Form
    {
        NEGEmpleados objetoCN = new NEGEmpleados();
        private int IdEmpleado = 0;
        // Fuente de datos para enlazar el DataGridView
        private readonly BindingSource _bs = new BindingSource();

        public frmEmpleados()
        {
            InitializeComponent();

            // Configuración básica del grid
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Asegura mapeos y que las columnas de acción sean botones
            AsegurarColumnas();

            // Enlaza el grid a la fuente
            dgvEmpleados.DataSource = _bs;

            // Eventos: el botón Buscar se cablea aquí (en el diseñador no está)
            btnBuscarEmpleados.Click += (_, __) => Cargar(txtBuscarEmpleados.Text?.Trim());

            // Enter en el cuadro de búsqueda para disparar la búsqueda
            txtBuscarEmpleados.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    Cargar(txtBuscarEmpleados.Text?.Trim());
                }
            };
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // Limpia el texto por defecto del campo de búsqueda
            txtBuscarEmpleados.Text = string.Empty;
            dgvEmpleados.AutoGenerateColumns = false;


            // Carga inicial: muestra todos los registros
            Cargar(null);
        }
        private void AsegurarColumnas()
        {
            // Mapea columnas de datos a las propiedades del modelo Empleado


            var colId = dgvEmpleados.Columns["IdEmpleado"];
            if (colId != null) colId.DataPropertyName = "IdEmpleado";

            var colNombre = dgvEmpleados.Columns["strNombre"];
            if (colNombre != null) colNombre.DataPropertyName = "strNombre";

            var colDoc = dgvEmpleados.Columns["NumDocumento"];
            if (colDoc != null) colDoc.DataPropertyName = "NumDocumento";

            var colTel = dgvEmpleados.Columns["StrTelefono"];
            if (colTel != null) colTel.DataPropertyName = "StrTelefono";

            var colCorreo = dgvEmpleados.Columns["StrEmail"];
            if (colCorreo != null) colCorreo.DataPropertyName = "StrEmail";

            var colDir = dgvEmpleados.Columns["StrDireccion"];
            if (colDir != null) colDir.DataPropertyName = "StrDireccion";

            var colRol = dgvEmpleados.Columns["NombreRol"];
            if (colRol != null) colRol.DataPropertyName = "NombreRol";

            // Asegura que colEditar sea un botón con texto "Editar"
            var colEditar = dgvEmpleados.Columns["colEditar"];
            if (colEditar != null && colEditar.GetType() != typeof(DataGridViewButtonColumn))
            {
                int idx = colEditar.Index;
                dgvEmpleados.Columns.RemoveAt(idx);
                var btn = new DataGridViewButtonColumn
                {
                    Name = "colEditar",
                    HeaderText = "EDITAR",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvEmpleados.Columns.Insert(idx, btn);
            }
            else if (colEditar is DataGridViewButtonColumn btnE)
            {
                btnE.HeaderText = "EDITAR";
                btnE.Text = "Editar";
                btnE.UseColumnTextForButtonValue = true;
                btnE.Width = 90;
            }

            // Asegura que colBorrar sea un botón con texto "Borrar"
            var colBorrar = dgvEmpleados.Columns["colBorrar"];
            if (colBorrar != null && colBorrar.GetType() != typeof(DataGridViewButtonColumn))
            {
                int idx = colBorrar.Index;
                dgvEmpleados.Columns.RemoveAt(idx);
                var btn = new DataGridViewButtonColumn
                {
                    Name = "colBorrar",
                    HeaderText = "BORRAR",
                    Text = "Borrar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvEmpleados.Columns.Insert(idx, btn);
            }
            else if (colBorrar is DataGridViewButtonColumn btnB)
            {
                btnB.HeaderText = "BORRAR";
                btnB.Text = "Borrar";
                btnB.UseColumnTextForButtonValue = true;
                btnB.Width = 90;
            }
        }
        private void Cargar(string? filtro)
        {
            DataTable dt = objetoCN.View();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                var dv = dt.DefaultView;
                dv.RowFilter = $"strNombre LIKE '%{filtro.Replace("'", "''")}%'";
                _bs.DataSource = dv;
            }
            else
            {
                _bs.DataSource = dt;
            }
        }

        void BorrarEmpleado(int idEmpleado)
        {
            var r = MessageBox.Show(
                $"¿Eliminar el empleado con Id {idEmpleado}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r != DialogResult.Yes) return;

            try
            {
                objetoCN.Delete(idEmpleado, Environment.UserName);
                MessageBox.Show("Empleado eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarConFiltroActual()
        {
            var filtro = string.IsNullOrWhiteSpace(txtBuscarEmpleados.Text)
                ? null
                : txtBuscarEmpleados.Text.Trim();

            Cargar(filtro);
        }

        // Handler del botón "Agregar cliente" (cableado en el diseñador)
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            //codigo para abrir el formulario FrmInsertarClientes en modo de inserción (IdCliente = 0)
            FrmEmpleadoEdit Empleado = new FrmEmpleadoEdit();
            Empleado.IdEmpleado = 0;
            var result = Empleado.ShowDialog();
            if (result == DialogResult.OK)
            {
                Cargar(null);
            }
        }

        // Handler del grid para botones Editar/Borrar (cableado en el diseñador)
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvEmpleados.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            if (col == null) return;

            var row = dgvEmpleados.Rows[e.RowIndex];
            if (row == null) return;

            // Validar que la celda "IdEmpleado" tenga valor antes de convertir
            if (row.Cells["ID"].Value == null)
            {
                MessageBox.Show("No se encontró el ID del empleado seleccionado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEmpleado = Convert.ToInt32(row.Cells["ID"].Value);

            if (col.Name == "colEditar")
            {
                try
                {
                    var empleado = new Empleado
                    {
                        Id = idEmpleado,
                        Nombre = row.Cells["CLIENTE"].Value?.ToString() ?? "",
                        Documento = row.Cells["DOCUMENTO"].Value?.ToString() ?? "",
                        Telefono = row.Cells["TELEFONO"].Value?.ToString() ?? "",
                        Correo = row.Cells["CORREO"].Value?.ToString() ?? "",
                        Direccion = row.Cells["DIRECCIÓN"].Value?.ToString() ?? "",
                        NombreRol = row.Cells["ROL"].Value?.ToString() ?? ""
                    };

                    using (FrmEmpleadoEdit dlg = new FrmEmpleadoEdit(empleado))
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            Cargar(null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el formulario de edición: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (col.Name == "colBorrar")
            {
                BorrarEmpleado(idEmpleado);
            }
        }

        // Evento del label generado por el diseñador (sin lógica)
        private void materialLabel1_Click(object sender, EventArgs e) { }
      
    }
}
