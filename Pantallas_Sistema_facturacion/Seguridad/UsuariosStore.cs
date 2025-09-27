using System;
using System.Collections.Generic;
using System.Linq;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    // Modelo de credenciales (renombrado para evitar choque con otra clase 'Usuario')
    public class CredencialUsuario
    {
        public int EmpleadoId { get; set; }
        public string Username { get; set; } = ""; // En producción: usar hash y reglas deunicidad en BD
        public string Password { get; set; } = ""; // En producción: NUNCA guardar texto plano
    }

    public static class UsuariosStore
    {
        // Índice por empleado (EmpleadoId -> credencial)
        private static readonly Dictionary<int, CredencialUsuario> _porEmpleado = new();

        // Índice por username (ignore case) -> EmpleadoId
        private static readonly Dictionary<string, int> _porUsername =
            new(StringComparer.OrdinalIgnoreCase);

        // Crea o actualiza credenciales garantizando que 'username' sea único
        public static bool Upsert(int empleadoId, string username, string password, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(username))
            {
                error = "El usuario es requerido.";
                return false;
            }

            username = username.Trim();

            // Si el username ya existe y pertenece a otro empleado -> error
            if (_porUsername.TryGetValue(username, out var otroEmpId) && otroEmpId != empleadoId)
            {
                error = "Ese usuario ya está en uso.";
                return false;
            }

            // Si ya tenía credencial, liberar el username anterior si cambió
            if (_porEmpleado.TryGetValue(empleadoId, out var existente))
            {
                if (!string.Equals(existente.Username, username, StringComparison.OrdinalIgnoreCase) &&
                    !string.IsNullOrWhiteSpace(existente.Username))
                {
                    _porUsername.Remove(existente.Username);
                }

                existente.Username = username;
                existente.Password = password;
            }
            else
            {
                _porEmpleado[empleadoId] = new CredencialUsuario
                {
                    EmpleadoId = empleadoId,
                    Username = username,
                    Password = password
                };
            }

            // Reindexa el username hacia este EmpleadoId
            _porUsername[username] = empleadoId;
            return true;
        }

        // Obtiene por EmpleadoId (o null si no existe)
        public static CredencialUsuario? GetByEmpleadoId(int empleadoId)
        {
            _porEmpleado.TryGetValue(empleadoId, out var u);
            return u;
        }

        // Obtiene por Username (o null si no existe)
        public static CredencialUsuario? GetByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return null;
            if (!_porUsername.TryGetValue(username.Trim(), out var empId)) return null;
            return GetByEmpleadoId(empId);
        }

        // Valida usuario/clave (solo para práctica)
        public static bool ValidateCredentials(string username, string password, out CredencialUsuario? user)
        {
            user = null;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            var u = GetByUsername(username);
            if (u == null) return false;

            if (!string.Equals(u.Password, password, StringComparison.Ordinal))
                return false;

            user = u;
            return true;
        }

        // Crea un admin por defecto si no existe (útil en primera ejecución / pruebas)
        public static void EnsureDefaultAdmin()
        {
            if (_porUsername.ContainsKey("admin")) return;

            // Usa un empleado existente o crea uno de ejemplo
            Empleado empRef = EmpleadoStore.Empleados.FirstOrDefault();
            if (empRef == null)
            {
                EmpleadoStore.Add("Administrador del sistema", "999999999", "0000000", "", "", null, null);
                empRef = EmpleadoStore.Empleados.Last();
            }

            // Línea original:
            // EmpleadoStore.Add("Administrador del sistema", "999999999", "0000000", "", "", null, null);

            // Línea corregida: se agrega el argumento requerido "correo" (por ejemplo, vacío "")
            EmpleadoStore.Add("Administrador del sistema", "999999999", "0000000", "", "", null, null);
            Upsert(empRef.Id, "admin", "123", out _);
        }
    }
}


