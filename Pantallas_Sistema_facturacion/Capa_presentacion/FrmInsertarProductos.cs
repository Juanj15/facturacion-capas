using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;

namespace FrmCategoria
{
    public partial class FrmInsertarProductos : Form
    {
        private readonly NEGProducto _productoService = new NEGProducto();
        private readonly NEGCategoria _categoriaService = new NEGCategoria();

        public FrmInsertarProductos()
        {
            InitializeComponent();
        }

        // Indica si se está creando o editando
        public string Id_Producto { get; set; }

        // Carga inicial del formulario
        private void FrmInsertarProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();

            if (string.IsNullOrEmpty(Id_Producto))
            {
                LblTituloProducto.Text = "Nuevo Producto";
                LimpiarFormulario();
            }
            else
            {
                LblTituloProducto.Text = "Editar Producto";
                CargarProducto(Id_Producto);
            }
        }

        // Carga las categorías en el ComboBox
        private void CargarCategorias()
        {
            try
            {
                DataTable categorias = _categoriaService.ObtenerCategorias();

                ComboxCategoria.DataSource = categorias;
                ComboxCategoria.DisplayMember = "StrDescripcion"; // Texto visible
                ComboxCategoria.ValueMember = "IdCategoria";     // Valor real (int)
                ComboxCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cargar un producto existente
        private void CargarProducto(string codigo)
        {
            try
            {
                var producto = _productoService.ObtenerProductoPorCodigo(codigo);

                if (producto == null)
                {
                    MessageBox.Show("No se encontró el producto.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TxtReferencia.Text = producto["StrCodigo"]?.ToString() ?? string.Empty;
                TxtNombre.Text = producto["StrNombre"]?.ToString() ?? string.Empty;

                // Selecciona la categoría correcta en el ComboBox
                if (int.TryParse(producto["IdCategoria"]?.ToString(), out int idCategoria))
                {
                    ComboxCategoria.SelectedValue = idCategoria;
                }

                TxtVenta.Text = producto["NumPrecioVenta"]?.ToString() ?? string.Empty;
                TxtStock.Text = producto["NumStock"]?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el producto: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Guardar o actualizar un producto
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtReferencia.Text) ||
                    string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                    ComboxCategoria.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(TxtVenta.Text) ||
                    string.IsNullOrWhiteSpace(TxtStock.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(TxtVenta.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un número válido.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(TxtStock.Text, out int stock))
                {
                    MessageBox.Show("El stock debe ser un número entero válido.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el ID de la categoría seleccionada (int)
                int idCategoria = Convert.ToInt32(ComboxCategoria.SelectedValue);

                bool ok;
                string error;

                if (string.IsNullOrEmpty(Id_Producto))
                {
                    // Crear nuevo producto
                    ok = _productoService.CrearProducto(
                        TxtReferencia.Text.Trim(),
                        TxtNombre.Text.Trim(),
                        idCategoria,
                        precio,
                        stock,
                        out error
                    );
                }
                else
                {
                    // Actualizar producto existente
                    ok = _productoService.ActualizarProducto(
                        Id_Producto,
                        TxtNombre.Text.Trim(),
                        idCategoria,
                        precio,
                        stock,
                        out error
                    );
                }

                if (ok)
                {
                    MessageBox.Show("Producto guardado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error: " + error,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar los campos
        private void LimpiarFormulario()
        {
            TxtReferencia.Clear();
            TxtNombre.Clear();
            ComboxCategoria.SelectedIndex = -1;
            TxtVenta.Clear();
            TxtStock.Clear();
        }

        // Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

