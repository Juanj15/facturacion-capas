using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Capa_Negocio;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class FrmEmpleadoEdit : Form
    {
        BLLEmpleados objetoCN = new BLLEmpleados();
        private readonly Empleado _original;
        private readonly ErrorProvider errorProvider1;

        // Salida para el llamador
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

        public FrmEmpleadoEdit()
        {
            InitializeComponent();

            errorProvider1 = new ErrorProvider { ContainerControl = this };

            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;

            txtDocumento.KeyPress += SoloNumeros_KeyPress;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;

            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarRoles(); // ⇦ ahora desde BD
            Shown += (_, __) => txtNombre.Focus();
        }

        private void CargarRoles()
        {
            try
            {
                // Carga desde BD con ADO.NET
                var roles = RolesDAO.ObtenerParaCombo(); // ⇦ Cambiado a método existente
                cboRol.DataSource = roles;     // ⇦ lista de RolItem
                cboRol.ValueMember = "Id";     // ⇦ Id para SelectedValue
                cboRol.DisplayMember = "NombreRol";
                cboRol.SelectedIndex = roles.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                // Comentario corto: muestra error si falla la consulta
                MessageBox.Show("Error cargando roles: " + ex.Message, "Roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRol.DataSource = null;
            }
        }

        public FrmEmpleadoEdit(Empleado existente) : this()
        {
            _original = existente;

            // Pinta campos
            txtNombre.Text = existente.Nombre;
            txtDocumento.Text = existente.Documento;
            txtTelefono.Text = existente.Telefono;
            txtCorreo.Text = existente.Correo;
            txtDireccion.Text = existente.Direccion;

            // Selección de rol robusta:
            // 1) Intentar por Id
            if (existente.IdRolEmpleado.HasValue)
            {
                cboRol.SelectedValue = existente.IdRolEmpleado.Value;
                if (cboRol.SelectedIndex >= 0) return; // ok
            }

            // 2) Intentar por nombre (si vino sin Id)
            if (!string.IsNullOrWhiteSpace(existente.NombreRol) && cboRol.Items.Count > 0)
            {
                for (int i = 0; i < cboRol.Items.Count; i++)
                {
                    var item = (RolItem)cboRol.Items[i];
                    if (string.Equals(item.NombreRol, existente.NombreRol, StringComparison.OrdinalIgnoreCase))
                    {
                        cboRol.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        // Crea un Empleado listo para guardar (lo usa el formulario padre)
        public Empleado ToEmpleado()
        {
            return new Empleado
            {
                // Nota: el Id lo asigna el llamador en edición (mantiene el existente)
                Nombre = this.Nombre,
                Documento = this.Documento,
                Telefono = this.Telefono,
                Correo = this.Correo,
                Direccion = this.Direccion,
                IdRolEmpleado = this.IdRolEmpleado,
                NombreRol = this.NombreRol
            };
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

            if (string.IsNullOrWhiteSpace(Direccion))
            {
                errorProvider1.SetError(txtDireccion, "La dirección es necesaria");
                ok = false;
            }

            if (IdRolEmpleado == null)
            {
                errorProvider1.SetError(cboRol, "Selecciona un rol");
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

            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validación de controles
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return;
                }
                if (txtDocumento.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDocumento.Focus();
                    return;
                }
                if (txtTelefono.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                    return;
                }
                if (txtCorreo.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nro de Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreo.Focus();
                    return;
                }
                if (txtDireccion.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nivel de Seguridad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();
                    return;
                }

                objetoCN.Create(txtNombre.Text, Convert.ToInt32(txtDocumento.Text), txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, 1, DateTime.Now, DateTime.Now, "prueba", DateTime.Now, "prueba usuario", Convert.ToBoolean(1));
                MessageBox.Show("Se guardo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos, se encontro el siguiente error : " + ex);
            }
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

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }
    }
}