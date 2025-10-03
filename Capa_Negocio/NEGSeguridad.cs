using System;
using System.Linq;
using System.Text.RegularExpressions;
using Capa_Datos;

namespace Capa_Negocio
{
    public class NEGSeguridad
    {
        /// <summary>
        /// Obtiene las credenciales de seguridad de un empleado por su ID.
        /// </summary>
        public UsuarioSeguridad ObtenerUsuarioPorEmpleado(int idEmpleado)
        {
            return UsuarioDAO.BuscarPorEmpleadoId(idEmpleado);
        }

        /// <summary>
        /// Guarda o actualiza las credenciales de un usuario.
        /// </summary>
        public bool GuardarUsuario(int idEmpleado, string username, string password, out string error)
        {
            error = string.Empty;

            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(username))
            {
                error = "El usuario no puede estar vacío.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                error = "La contraseña no puede estar vacía.";
                return false;
            }

            return UsuarioDAO.Guardar(idEmpleado, username, password, out error);
        }

        /// <summary>
        /// Valida las credenciales del usuario según reglas de negocio.
        /// </summary>
        public bool ValidarCredenciales(string username, string password, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(username))
            {
                error = "El usuario es requerido.";
                return false;
            }
            if (username.Contains(" "))
            {
                error = "El usuario no debe tener espacios.";
                return false;
            }
            if (password.Length < 6)
            {
                error = "La contraseña debe tener al menos 6 caracteres.";
                return false;
            }
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                error = "La contraseña debe ser alfanumérica (sin símbolos ni espacios).";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtiene una lista de nombres únicos de empleados.
        /// </summary>
        public string[] ObtenerNombresEmpleados()
        {
            return EmpleadoDAO.ObtenerTodos()
                .Select(e => e.Nombre)
                .Distinct()
                .OrderBy(n => n)
                .ToArray();
        }

        /// <summary>
        /// Obtiene un empleado por su nombre.
        /// </summary>
        public EmpleadoDTO ObtenerEmpleadoPorNombre(string nombre)
        {
            var empleado = EmpleadoDAO.ObtenerTodos()
                .FirstOrDefault(e => string.Equals(e.Nombre, nombre, StringComparison.OrdinalIgnoreCase));
            if (empleado == null) return null;
            return new EmpleadoDTO
            {
                Id = empleado.Id,
                Nombre = empleado.Nombre,
                Documento = empleado.Documento,
                Telefono = empleado.Telefono,
                Correo = empleado.Correo,
                Direccion = empleado.Direccion,
                IdRolEmpleado = empleado.IdRolEmpleado,
                NombreRol = empleado.NombreRol
            };
        }
    }
}
