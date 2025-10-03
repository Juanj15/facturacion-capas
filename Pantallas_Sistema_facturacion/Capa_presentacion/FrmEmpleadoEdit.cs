using Capa_Negocio;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class FrmEmpleadoEdit : Form
    {
        private readonly EmpleadoService empleadoService = new EmpleadoService();
        private readonly NEGRoles objetoCD = new NEGRoles();
        private readonly ErrorProvider errorProvider1;

        // Salida para la llamada
        public string Nombre => txtNombre.Text.Trim();
        public string Documento => txtDocumento.Text.Trim();
        public string Telefono => txtTelefono.Text.Trim();
        public string Correo => txtCorreo.Text.Trim();
        public string Direccion => txtDireccion.Text.Trim();

        public int? IdRolEmpleado
        {
            get
            {
                var v = cboRol.SelectedValue;
                if (v == null || v == DBNull.Value) return null;
                return Convert.ToInt32(v);
            }
        }

        public string NombreRol => cboRol.Text?.Trim() ?? "";

        public int IdEmpleado { get; set; }

        // Constructor para crear un nuevo empleado
        public FrmEmpleadoEdit()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider { ContainerControl = this };
            CargarRoles();
        }

        // Constructor para editar un empleado existente
        public FrmEmpleadoEdit(EmpleadoDTO existente) : this()
        {
            if (existente == null) return;

            IdEmpleado = existente.Id;

            txtNombre.Text = existente.Nombre;
            txtDocumento.Text = existente.Documento;
            txtTelefono.Text = existente.Telefono;
            txtCorreo.Text = existente.Correo;
            txtDireccion.Text = existente.Direccion;

            if (existente.IdRolEmpleado.HasValue)
            {
                cboRol.SelectedValue = existente.IdRolEmpleado.Value;
            }
        }

        private void CargarRoles()
        {
            try
            {
                DataTable dt = objetoCD.ObtenerRoles();

                cboRol.DataSource = dt;
                cboRol.DisplayMember = "NombreRol";  
                cboRol.ValueMember = "NombreRol";        
                cboRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SoloDigitos(string s) =>
            !string.IsNullOrWhiteSpace(s) && s.All(char.IsDigit);

        private bool Validar()
        {
            errorProvider1.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                errorProvider1.SetError(txtNombre, "El nombre es requerido");
                ok = false;
            }

            if (!SoloDigitos(Documento))
            {
                errorProvider1.SetError(txtDocumento, "Documento numérico");
                ok = false;
            }

            if (!string.IsNullOrWhiteSpace(Telefono) && !SoloDigitos(Telefono))
            {
                errorProvider1.SetError(txtTelefono, "Teléfono numérico (opcional)");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(Correo))
            {
                errorProvider1.SetError(txtCorreo, "El correo es necesario");
                ok = false;
            }
            else
            {
                // Regex básica para validar formato de email
                var regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!regexEmail.IsMatch(Correo))
                {
                    errorProvider1.SetError(txtCorreo, "Formato de correo no válido");
                    ok = false;
                }
            }

            if (string.IsNullOrWhiteSpace(Direccion))
            {
                errorProvider1.SetError(txtDireccion, "La dirección es necesaria");
                ok = false;
            }

            return ok;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                if (!long.TryParse(txtDocumento.Text.Trim(), out _))
                {
                    MessageBox.Show("El documento debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Focus();
                    return;
                }

                // 🔹 Construyo DTO desde la UI
                var dto = new EmpleadoDTO
                {
                    Id = IdEmpleado,
                    Nombre = txtNombre.Text.Trim(),
                    Documento = txtDocumento.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    IdRolEmpleado = IdRolEmpleado,
                    NombreRol = NombreRol
                };

                if (IdEmpleado == 0)
                {
                    empleadoService.Create(dto, Environment.UserName);
                    MessageBox.Show("Empleado creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    empleadoService.Update(dto, Environment.UserName);
                    MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
