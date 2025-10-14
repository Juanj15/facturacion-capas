using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class NEGProducto
    {
        private readonly ProductoDAO _productoDAO = new ProductoDAO();

        public DataTable ObtenerProductos(string filtro = "")
        {
            return _productoDAO.ObtenerProductos(filtro);
        }

        public DataRow ObtenerProductoPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío.");

            return _productoDAO.ObtenerProductoPorCodigo(codigo);
        }

        // Crear producto
        public bool CrearProducto(string codigo, string nombre, int idCategoria, decimal precio, int stock, out string error)
        {
            error = string.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
                {
                    error = "El código y el nombre son obligatorios.";
                    return false;
                }

                if (idCategoria <= 0)
                {
                    error = "Debe seleccionar una categoría válida.";
                    return false;
                }

                _productoDAO.InsertarProducto(codigo, nombre, idCategoria, precio, stock);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Actualizar producto
        public bool ActualizarProducto(string codigo, string nombre, int idCategoria, decimal precio, int stock, out string error)
        {
            error = string.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    error = "Debe especificar el código del producto.";
                    return false;
                }

                if (idCategoria <= 0)
                {
                    error = "Debe seleccionar una categoría válida.";
                    return false;
                }

                _productoDAO.ActualizarProducto(codigo, nombre, idCategoria, precio, stock);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Eliminar producto
        public bool EliminarProducto(string codigo, out string error)
        {
            error = string.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    error = "Debe especificar el código del producto.";
                    return false;
                }

                _productoDAO.EliminarProducto(codigo);
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
