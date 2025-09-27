using Capa_Negocio;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmEmpleados : Form
    {
        BLLEmpleados objetoCN = new BLLEmpleados();
        private int idEmpleado = 0;
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
            dgvEmpleados.AutoGenerateColumns = true;


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

            var colRol = dgvEmpleados.Columns["IdRolEmpleado"];
            if (colRol != null) colRol.DataPropertyName = "IdRolEmpleado";

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
                // Filtrado en memoria usando DataTable
                var dv = dt.DefaultView;
                // Ajusta el nombre de la columna según tu base de datos (ejemplo: "strNombre")
                dv.RowFilter = $"strNombre LIKE '%{filtro.Replace("'", "''")}%'";
                dgvEmpleados.DataSource = dv;
            }
            else
            {
                dgvEmpleados.DataSource = dt;
            }
        }
        private void NuevoEmpleado()
        {
            using var dlg = new FrmEmpleadoEdit();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                var emp = dlg.ToEmpleado();   // ahora sí existe
                EmpleadoDAO.Guardar(emp, Environment.UserName);
                RefrescarConFiltroActual();
            }
        }
        private void EditarEmpleado(Empleado emp)
        {
            using var dlg = new FrmEmpleadoEdit(emp);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                var actualizado = dlg.ToEmpleado();
                actualizado.Id = emp.Id;      // conserva el Id original
                EmpleadoDAO.Guardar(actualizado, Environment.UserName);
                RefrescarConFiltroActual();
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
                objetoCN.Delete(idEmpleado);
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
        private void btnNuevoEmpleado_Click(object sender, EventArgs e) => NuevoEmpleado();

        // Handler del grid para botones Editar/Borrar (cableado en el diseñador)
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dgvEmpleados.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            if (col == null) return;

            // Obtén el IdEmpleado de la fila seleccionada
            var row = dgvEmpleados.Rows[e.RowIndex];
            int idEmpleado = Convert.ToInt32(row.Cells["IdEmpleado"].Value);

            if (col.Name == "colEditar")
            {
                // Aquí deberías cargar el empleado por Id si necesitas editar
                // Ejemplo: EditarEmpleado(idEmpleado);
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
