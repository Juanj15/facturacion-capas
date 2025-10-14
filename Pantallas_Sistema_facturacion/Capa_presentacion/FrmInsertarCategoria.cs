using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;

namespace FrmCategoria
{
    public partial class FrmInsertarCategoria : Form
    {
        private readonly NEGCategoria _categoriaService = new NEGCategoria();

        public FrmInsertarCategoria()
        {
            InitializeComponent();
            this.Load += FrmInsertarCategoria_Load; // asegura que el Load esté cableado
        }

        // Constructor que recibe el ID a editar
        public FrmInsertarCategoria(int idCategoria) : this()
        {
            Id_Categoria = idCategoria;
        }

        public int Id_Categoria { get; set; }

        private void FrmInsertarCategoria_Load(object sender, EventArgs e)
        {
            if (Id_Categoria == 0)
            {
                LblTituloCategoria.Text = "Nueva Categoría";
                LimpiarFormulario();
            }
            else
            {
                LblTituloCategoria.Text = "Editar Categoría";
                CargarDatosCategoria(Id_Categoria);
            }
        }

        // Respaldo por si no se cargaron datos en Load
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Id_Categoria > 0 && string.IsNullOrWhiteSpace(TxtDescripcion.Text))
                CargarDatosCategoria(Id_Categoria);
        }

        private void CargarDatosCategoria(int idCategoria)
        {
            try
            {
                var categoria = _categoriaService.ObtenerCategoriaPorId(idCategoria);
                if (categoria == null)
                {
                    MessageBox.Show("No se encontró la categoría con ese ID.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TxTId_Categoria.Text = categoria["IdCategoria"]?.ToString() ?? "";
                TxtDescripcion.Text = categoria["StrDescripcion"]?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la categoría: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            TxTId_Categoria.Clear();
            TxtDescripcion.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = TxtDescripcion.Text.Trim();

                // Validar que la descripción no esté vacía
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Por favor, ingrese una descripción para la categoría.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool resultado;
                string error;

                // Crear o actualizar según corresponda
                if (Id_Categoria == 0)
                {
                    // Nueva categoría
                    resultado = _categoriaService.CrearCategoria(descripcion, out error);
                }
                else
                {
                    // Actualizar categoría existente
                    resultado = _categoriaService.ActualizarCategoria(Id_Categoria, descripcion, out error);
                }

                if (resultado)
                {
                    MessageBox.Show("Categoría guardada correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar la categoría: " + error,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}