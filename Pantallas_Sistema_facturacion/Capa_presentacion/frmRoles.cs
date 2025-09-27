using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmRoles : Form
    {
        private string _descripcionRolOriginal = "";
        private RolInfoDAO _rolCargado = null;

        public frmRoles()
        {
            InitializeComponent();

            ConfigurarAutoComplete();
            SetEstadosControles(hayRolCargado: false, hayCambios: false);

            this.Load += (_, __) => LimpiarUI();
            txtRolNombre.KeyDown += txtRolNombre_KeyDown_EnterBusca;
            txtRolNombre.Leave += (_, __) => CargarRolDesdeUI();
            txtRolDescripcion.TextChanged += (_, __) =>
            {
                bool hayCambios = _rolCargado != null &&
                                  !string.Equals(txtRolDescripcion.Text ?? "",
                                                 _descripcionRolOriginal ?? "",
                                                 StringComparison.Ordinal);
                SetEstadosControles(hayRolCargado: _rolCargado != null, hayCambios: hayCambios);
            };
            btnRolActualizar.Click += (_, __) => GuardarDescripcion();
            btnRolCancelar.Click += (_, __) => CancelarCambios();
        }

        private void ConfigurarAutoComplete()
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(RolesDAO.ObtenerNombres()); // ⇦ desde BD

            txtRolNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRolNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRolNombre.AutoCompleteCustomSource = source;
        }

        private void LimpiarUI()
        {
            txtRolNombre.Text = "";
            txtRolDescripcion.Text = "";
            txtRolDescripcion.ReadOnly = true;
            _rolCargado = null;
            _descripcionRolOriginal = "";
            SetEstadosControles(hayRolCargado: false, hayCambios: false);
        }

        private void txtRolNombre_KeyDown_EnterBusca(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CargarRolDesdeUI();
            }
        }

        private void CargarRolDesdeUI()
        {
            var nombre = (txtRolNombre.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa el nombre del rol.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener o crear (NombreRol)
            var infoDao = RolesDAO.GetOrCreate(nombre);

            // Mapear RolInfoDAO a RolInfo
            var info = new RolInfoDAO
            {
                NombreRol = infoDao.NombreRol,
                DescripcionRol = infoDao.DescripcionRol
            };
            _rolCargado = info;

            txtRolDescripcion.Text = info.DescripcionRol ?? ""; // mapea a Descripcion
            _descripcionRolOriginal = txtRolDescripcion.Text;

            txtRolDescripcion.ReadOnly = false;
            SetEstadosControles(hayRolCargado: true, hayCambios: false);
        }

        private void GuardarDescripcion()
        {
            if (_rolCargado == null)
            {
                MessageBox.Show("Primero carga un rol.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RolesDAO.ActualizarDescripcionRol(_rolCargado.Id, txtRolDescripcion.Text ?? "");

            _descripcionRolOriginal = txtRolDescripcion.Text ?? "";
            SetEstadosControles(hayRolCargado: true, hayCambios: false);
            MessageBox.Show("Descripción actualizada.", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelarCambios()
        {
            if (_rolCargado != null)
            {
                txtRolDescripcion.Text = _descripcionRolOriginal ?? "";
                SetEstadosControles(hayRolCargado: true, hayCambios: false);
            }
            else
            {
                LimpiarUI();
            }
        }

        private void SetEstadosControles(bool hayRolCargado, bool hayCambios)
        {
            btnRolActualizar.Enabled = hayRolCargado && hayCambios;
            btnRolCancelar.Enabled = hayRolCargado && hayCambios;
            txtRolDescripcion.ReadOnly = !hayRolCargado;
        }
        // Comentarios clave:
        // - Autocomplete viene de TBLROLES.NombreRol.
        // - Cargar/Crear usa GetOrCreate(nombre).
        // - Guardar solo impacta TBLROLES.DescripcionRol.
    }
}


