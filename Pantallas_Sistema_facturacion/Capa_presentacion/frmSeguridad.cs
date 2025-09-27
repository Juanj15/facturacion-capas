using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmSeguridad : Form
    {
        // Empleado actual seleccionado (null si no hay)
        private Empleado? _empleadoActual;

        // Valores originales para detectar cambios
        private string _usernameOriginal = "";
        private string _passwordOriginal = "";

        // Flag para silenciar TextChanged cuando limpiamos por código
        private bool _silencioUI = false;

        public frmSeguridad()
        {
            InitializeComponent();

            // Al cargar, arranca limpio
            this.Load += (_, __) => LimpiarUI();

            // Autocompletar de empleados (TextBox estándar)
            ConfigurarAutoComplete();

            // Enter en el buscador -> cargar empleado
            txtSegEmpleado.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    CargarEmpleadoDesdeUI();
                }
            };

            // Botones
            btnSegActualizar.Click += (_, __) => Guardar();   // guarda y limpia
            btnSegCancelar.Click += (_, __) => LimpiarUI();  // limpia

            // Cambios de texto -> habilitar/inhabilitar botones si hay diferencias
            txtSegUsuario.TextChanged += (_, __) => EvaluarCambios();
            txtSegClave.TextChanged += (_, __) => EvaluarCambios();

            // Validación temprana de tecleo (opcional, mejora UX)
            txtSegUsuario.KeyPress += Usuario_SinEspacios_KeyPress;
            txtSegClave.KeyPress += Clave_SoloAlfanum_KeyPress;
        }

        // Autocompleta con nombres únicos de la lista en memoria
        private void ConfigurarAutoComplete()
        {
            var src = new AutoCompleteStringCollection();
            var nombres = EmpleadoDAO.ObtenerTodos()
                                       .Select(e => e.Nombre)
                                       .Distinct()
                                       .OrderBy(n => n)
                                       .ToArray();
            src.AddRange(nombres);
            txtSegEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSegEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSegEmpleado.AutoCompleteCustomSource = src;
        }

        // Deja la UI lista para una nueva operación
        private void LimpiarUI()
        {
            _silencioUI = true;

            txtSegEmpleado.Text = "";
            txtSegUsuario.Text = "";
            txtSegClave.Text = "";

            txtSegUsuario.ReadOnly = true;
            txtSegClave.ReadOnly = true;

            _empleadoActual = null;
            _usernameOriginal = "";
            _passwordOriginal = "";

            SetBotones(false);

            _silencioUI = false;

            txtSegEmpleado.Focus();
        }

        // Habilita o deshabilita Actualizar/Cancelar
        private void SetBotones(bool habilitar)
        {
            btnSegActualizar.Enabled = habilitar;
            btnSegCancelar.Enabled = habilitar;
        }

        // Carga al empleado por nombre (primera coincidencia, ignore case)
        private void CargarEmpleadoDesdeUI()
        {
            var nombre = (txtSegEmpleado.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa el nombre del empleado.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var emp = EmpleadoDAO.ObtenerTodos()
            .FirstOrDefault(e => string.Equals(e.Nombre, nombre, StringComparison.OrdinalIgnoreCase));

            if (emp == null)
            {
                MessageBox.Show("Empleado no encontrado.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _empleadoActual = emp;

            var u = UsuarioDAO.BuscarPorEmpleadoId(emp.Id);
            _silencioUI = true; // evita parpadeo de botones al asignar textos
            txtSegUsuario.Text = u?.StrUsuario ?? "";
            txtSegClave.Text = u?.StrClave ?? ""; // solo práctica
            _silencioUI = false;

            _usernameOriginal = txtSegUsuario.Text;
            _passwordOriginal = txtSegClave.Text;

            txtSegUsuario.ReadOnly = false;
            txtSegClave.ReadOnly = false;

            SetBotones(false); // aún no hay cambios
            txtSegUsuario.Focus();
        }

        // Habilita botones si hay diferencias con lo guardado
        private void EvaluarCambios()
        {
            if (_silencioUI || _empleadoActual == null)
            {
                SetBotones(false);
                return;
            }

            bool hayCambios = !string.Equals(txtSegUsuario.Text, _usernameOriginal, StringComparison.Ordinal)
                           || !string.Equals(txtSegClave.Text, _passwordOriginal, StringComparison.Ordinal);

            SetBotones(habilitar: hayCambios);
        }

        // Validación de negocio: usuario requerido, sin espacios; clave >= 6, alfanumérica
        private bool ValidarCampos()
        {
            var user = (txtSegUsuario.Text ?? "").Trim();
            var pass = (txtSegClave.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("El usuario es requerido.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegUsuario.Clear();
                txtSegUsuario.Focus();
                return false;
            }
            if (user.Contains(" "))
            {
                MessageBox.Show("El usuario no debe tener espacios.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegUsuario.Clear();
                txtSegUsuario.Focus();
                return false;
            }

            if (pass.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegClave.Clear();
                txtSegClave.Focus();
                return false;
            }
            if (!Regex.IsMatch(pass, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("La contraseña debe ser alfanumérica (sin símbolos ni espacios).", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegClave.Clear();
                txtSegClave.Focus();
                return false;
            }

            return true;
        }

        // Guarda en el store (garantiza username único) y limpia la UI
        private void Guardar()
        {
            if (_empleadoActual == null)
            {
                MessageBox.Show("Primero selecciona un empleado.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarCampos()) return;

            var ok = UsuarioDAO.Guardar(_empleadoActual.Id,
                                          txtSegUsuario.Text.Trim(),
                                          txtSegClave.Text.Trim(),
                                          out var error);

            if (!ok)
            {
                MessageBox.Show(error, "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegUsuario.Focus();
                return;
            }

            MessageBox.Show("Credenciales actualizadas.", "OK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarUI(); // dejar listo para la siguiente asignación
        }

        // Bloquea espacios en el usuario (opcional)
        private void Usuario_SinEspacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        // Solo alfanuméricos en la clave (opcional)
        private void Clave_SoloAlfanum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}


