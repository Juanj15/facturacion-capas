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
        NEGEmpleados objetoCN = new NEGEmpleados();
        NEGRoles objetoCD = new NEGRoles();
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
            CargarRoles();
        }

        public FrmEmpleadoEdit(Empleado existente) : this()
        {
            if (existente == null) return;

            IdEmpleado = existente.Id;

            txtNombre.Text = existente.Nombre;
            txtDocumento.Text = existente.Documento;
            txtTelefono.Text = existente.Telefono;
            txtCorreo.Text = existente.Correo;
            txtDireccion.Text = existente.Direccion;

            if (!string.IsNullOrWhiteSpace(existente.NombreRol))
            {
                cboRol.SelectedIndex = cboRol.FindStringExact(existente.NombreRol);
            }
        }

        private void CargarRoles()
        {
            try
            {
                DataTable dt = objetoCD.ObtenerRoles();

                cboRol.DataSource = dt;
                cboRol.DisplayMember = "NombreRol";  // Lo que se muestra al usuario
                cboRol.ValueMember = "NombreRol";           // El valor real que usarás en BD (debe ser numérico)
                cboRol.SelectedIndex = -1;           // Inicialmente sin selección
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int IdEmpleado { get; set; }

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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                if (!long.TryParse(txtDocumento.Text.Trim(), out long documento))
                {
                    MessageBox.Show("El documento debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Focus();
                    return;
                }

                if (IdEmpleado == 0)
                {
                    objetoCN.Create(
                        txtNombre.Text.Trim(),
                        documento,
                        txtDireccion.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        txtCorreo.Text.Trim(),
                        NombreRol,
                        Environment.UserName
                    );
                    MessageBox.Show("Empleado creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objetoCN.Update(
                        IdEmpleado,
                        txtNombre.Text.Trim(),
                        documento,
                        txtTelefono.Text.Trim(),
                        txtCorreo.Text.Trim(),
                        txtDireccion.Text.Trim(),
                        NombreRol,
                        Environment.UserName
                    );
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