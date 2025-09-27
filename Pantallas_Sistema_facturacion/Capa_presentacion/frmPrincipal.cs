using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Pantallas_Sistema_facturacion.Seguridad; // frmEmpleados/frmRoles/frmSeguridad
using FrmCategoria; // FrmCategorias, etc.
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Pantallas_Sistema_facturacion
{
    public partial class frmPrincipal : MaterialForm
    {
        // Último form embebido en el panel de Seguridad
        private Form _formActualSeguridad = null;

        public frmPrincipal()
        {
            InitializeComponent();
            this.Load += frmPrincipal_Load; // estado inicial
        }

        // Estado inicial: Seguridad oculta, panel general visible
        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (pnlEmpleados != null) pnlEmpleados.Visible = false;
            if (panelContenedor != null) { panelContenedor.Visible = true; panelContenedor.BringToFront(); }
        }

        // Muestra/oculta el panel de Seguridad y limpia su contenido al ocultar
        private void ToggleSeguridad(bool mostrar)
        {
            if (mostrar)
            {
                if (panelContenedor != null) panelContenedor.Visible = false;
                pnlEmpleados.Visible = true;
                pnlEmpleados.BringToFront();
            }
            else
            {
                if (_formActualSeguridad != null)
                {
                    try { _formActualSeguridad.Close(); _formActualSeguridad.Dispose(); } catch { }
                    _formActualSeguridad = null;
                }

                pnlEmpleados.Controls.Clear();
                pnlEmpleados.Visible = false;

                if (panelContenedor != null)
                {
                    panelContenedor.Visible = true;
                    panelContenedor.BringToFront();
                }
            }
        }

        // Embebe un formulario dentro de un panel (para Seguridad)
        private void AbrirEnPanel(Form frm, Panel contenedor)
        {
            if (_formActualSeguridad != null)
            {
                try { _formActualSeguridad.Close(); _formActualSeguridad.Dispose(); } catch { }
                _formActualSeguridad = null;
            }

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            contenedor.Controls.Clear();
            contenedor.Controls.Add(frm);
            contenedor.Tag = frm;

            _formActualSeguridad = frm;
            frm.Show(); // importante: no usar ShowDialog aquí
        }

        // -------------------------
        //      HANDLERS VARIOS
        // -------------------------
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void Facturacion_Click(object sender, EventArgs e) { }
        private void Informes_Click(object sender, EventArgs e) { }
        private void TabOpcionesMenu_Click(object sender, EventArgs e) { }
        private void seguridad_Click(object sender, EventArgs e) { }
        private void pnlPrincipal_Paint(object sender, PaintEventArgs e) { }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new frmFacturas(), pnlEmpleados);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new frmInformes(), pnlEmpleados);
        }

        // --- SEGURIDAD (embebido en pnlEmpleados) ---
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new frmSeguridad(), pnlEmpleados); // por defecto, Credenciales
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new frmEmpleados(), pnlEmpleados);
        }

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new frmRoles(), pnlEmpleados);
        }

        // --- MÓDULOS GENERALES (comportamiento original) ---
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new FrmClientes(), pnlEmpleados);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new FrmProductos(), pnlEmpleados);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new FrmCategorias(), pnlEmpleados);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new frmAyuda(), pnlEmpleados);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            ToggleSeguridad(true);
            AbrirEnPanel(new frmAcerca(), pnlEmpleados);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
