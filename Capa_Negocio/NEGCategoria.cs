using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class NEGCategoria
    {
        // Objeto para acceder a la capa de datos
        private readonly CategoriaDAO _categoriaDAO = new CategoriaDAO();

        // Obtener todas las categorías (para listarlas o llenar combos)
        public DataTable ObtenerCategorias(string filtro = "")
        {
            return _categoriaDAO.ObtenerCategorias(filtro);
        }

        // Obtener una categoría por su ID (para edición)
        public DataRow ObtenerCategoriaPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la categoría no es válido.");

            var categoria = _categoriaDAO.ObtenerCategoriaPorId(id);
            return categoria; // devolvemos null si no existe, el formulario lo controla
        }

        // Obtener lista simplificada (Id y Descripción) para ComboBox
        public DataTable ObtenerCategoriasParaCombo()
        {
            // Este método se usa en frmInsertarProducto
            var dt = _categoriaDAO.ObtenerCategorias();
            // Aseguramos que las columnas existan y se llamen igual que en la BD
            dt.Columns["IdCategoria"].ColumnName = "IdCategoria";
            dt.Columns["StrDescripcion"].ColumnName = "StrDescripcion";
            return dt;
        }

        // Crear una nueva categoría
        public bool CrearCategoria(string descripcion, out string error)
        {
            error = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    error = "La descripción de la categoría no puede estar vacía.";
                    return false;
                }

                _categoriaDAO.InsertarCategoria(descripcion);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Actualizar una categoría existente
        public bool ActualizarCategoria(int id, string descripcion, out string error)
        {
            error = string.Empty;

            try
            {
                if (id <= 0)
                {
                    error = "Debe especificar un ID válido.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    error = "La descripción no puede estar vacía.";
                    return false;
                }

                _categoriaDAO.ActualizarCategoria(id, descripcion);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Eliminar categoría
        public bool EliminarCategoria(int id, out string error)
        {
            error = string.Empty;

            try
            {
                if (id <= 0)
                {
                    error = "Debe especificar un ID válido para eliminar.";
                    return false;
                }

                _categoriaDAO.EliminarCategoria(id);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}

