using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Capa_Negocio;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmSeguridad : Form
    {

        private readonly NEGSeguridad _negocioSeguridad = new NEGSeguridad();
        private EmpleadoDTO? _empleadoActual;

        private string _usernameOriginal = "";
        private string _passwordOriginal = "";

        private bool _silencioUI = false;

        public frmSeguridad()
        {
            InitializeComponent();

            // Al cargar, arranca limpio
            this.Load += (_, __) => LimpiarUI();

            // Autocompletar de empleados (TextBox estándar)
            ConfigurarAutoComplete();

            // Enter en el buscador > cargar empleado
            txtSegEmpleado.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    CargarEmpleadoDesdeUI();
                }
            };

            btnSegActualizar.Click += (_, __) => Guardar();
            btnSegCancelar.Click += (_, __) => LimpiarUI();

            // Cambios de texto > habilitar/inhabilitar botones si hay diferencias
            txtSegUsuario.TextChanged += (_, __) => EvaluarCambios();
            txtSegClave.TextChanged += (_, __) => EvaluarCambios();

            txtSegUsuario.KeyPress += Usuario_SinEspacios_KeyPress;
            txtSegClave.KeyPress += Clave_SoloAlfanum_KeyPress;
        }

        // Autocompleta con nombres únicos de la lista en memoria
        private void ConfigurarAutoComplete()
        {
            var src = new AutoCompleteStringCollection();
            var nombres = _negocioSeguridad.ObtenerNombresEmpleados();
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

            _empleadoActual = null; // Inicializa _empleadoActual como null
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
            var nombreBuscado = txtSegEmpleado.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreBuscado))
            {
                MessageBox.Show("Ingrese el nombre del empleado.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = _negocioSeguridad.ObtenerEmpleadoPorNombre(nombreBuscado);

            if (empleado == null)
            {
                MessageBox.Show("Empleado no encontrado.");
                LimpiarUI();
                return;
            }

            _empleadoActual = empleado;

            var usuario = _negocioSeguridad.ObtenerUsuarioPorEmpleado(empleado.Id);
            if (usuario != null)
            {
                txtSegUsuario.Text = usuario.StrUsuario;
                txtSegClave.Text = usuario.StrClave;
                _usernameOriginal = usuario.StrUsuario;
                _passwordOriginal = usuario.StrClave;
                txtSegUsuario.ReadOnly = false;
                txtSegClave.ReadOnly = false;
            }
            else
            {
                txtSegUsuario.Text = "";
                txtSegClave.Text = "";
                _usernameOriginal = "";
                _passwordOriginal = "";
                txtSegUsuario.ReadOnly = false;
                txtSegClave.ReadOnly = false;
            }

            EvaluarCambios();
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

        // Validación de negocio delegada a NEGSeguridad
        private bool ValidarCampos()
        {
            var user = (txtSegUsuario.Text ?? "").Trim();
            var pass = (txtSegClave.Text ?? "").Trim();

            var valido = _negocioSeguridad.ValidarCredenciales(user, pass, out var errorMsg);
            if (!valido)
            {
                MessageBox.Show(errorMsg, "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (errorMsg.Contains("usuario")) txtSegUsuario.Focus();
                else txtSegClave.Focus();
            }
            return valido;
        }

        // Guarda en la capa de negocio y limpia la UI
        private void Guardar()
        {
            if (_empleadoActual == null)
            {
                MessageBox.Show("Primero selecciona un empleado.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarCampos()) return;

            var ok = _negocioSeguridad.GuardarUsuario(_empleadoActual.Id, // Usa el DTO para acceder al Id.
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

            LimpiarUI();
        }

        // Bloquea espacios en el usuario
        private void Usuario_SinEspacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        // Solo alfanuméricos en la clave
        private void Clave_SoloAlfanum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}


