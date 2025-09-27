using System;
using System.Collections.Generic;
using System.Linq;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public class RolInfo
    {
        public string Nombre { get; set; } = "";
        public string DescripcionDefault { get; set; } = "";
        public string Descripcion { get; set; } = "";
    }

    public static class RolesStore
    {
        // Diccionario interno, clave en minúsculas para comparación case-insensitive
        private static readonly Dictionary<string, RolInfo> _roles = new(StringComparer.OrdinalIgnoreCase)
        {
            ["Administrador"] = new RolInfo
            {
                Nombre = "Administrador",
                DescripcionDefault =
                @"Responsabilidades:
                - Acceso total al sistema y a todos los módulos.
                - CRUD completo (crear, leer, actualizar, borrar) sobre entidades principales.
                - Gestión de usuarios, contraseñas y roles.
                - Configuración de seguridad y permisos.

                Restricciones:
                - Debe cumplir lineamientos de auditoría y trazabilidad.

                Ejemplos de tareas:
                - Crear nuevos usuarios y asignar roles.
                - Modificar parámetros del sistema.
                - Revocar accesos cuando corresponda.",
                Descripcion = null // se setea abajo como copia del Default
            },
            ["Coordinador"] = new RolInfo
            {
                Nombre = "Coordinador",
                DescripcionDefault =
                @"Responsabilidades:
                - Supervisar la operación diaria y el cumplimiento de metas.
                - Asignar tareas y hacer seguimiento a equipos.
                - Aprobar/actualizar información operativa (empleados, clientes) según políticas.

                Restricciones:
                - No gestiona roles ni configuraciones de seguridad.

                Ejemplos de tareas:
                - Revisar reportes de desempeño.
                - Actualizar datos de empleados.
                - Coordinar acciones entre áreas.",
                Descripcion = null
            },
            ["Vendedor"] = new RolInfo
            {
                Nombre = "Vendedor",
                DescripcionDefault =
                @"Responsabilidades:
                - Gestionar cartera de clientes y oportunidades.
                - Registrar ventas y cotizaciones.
                - Consultar disponibilidad de inventario y precios.

                Restricciones:
                - Sin acceso a administración de seguridad o roles.
                - Sin permisos para modificar configuración global.

                Ejemplos de tareas:
                - Crear/actualizar clientes.
                - Registrar pedidos y seguimiento postventa.",
                Descripcion = null
            },
            ["Soporte"] = new RolInfo
            {
                Nombre = "Soporte",
                DescripcionDefault =
                @"Responsabilidades:
                - Atender incidencias y solicitudes técnicas.
                - Diagnosticar problemas y proponer soluciones.
                - Documentar soluciones y mantener base de conocimiento.

                Restricciones:
                - Sin acceso a ventas ni a configuración de seguridad.

                Ejemplos de tareas:
                - Crear tickets de soporte.
                - Actualizar estados y registrar soluciones.",
                Descripcion = null
            },
            ["Auditor"] = new RolInfo
            {
                Nombre = "Auditor",
                DescripcionDefault =
                @"Responsabilidades:
                - Revisión de registros y trazabilidad.
                - Verificación de cumplimiento de políticas.

                Restricciones:
                - Acceso de solo lectura a datos y reportes.
                - Sin posibilidad de modificar información.

                Ejemplos de tareas:
                - Consultar informes históricos.
                - Validar integridad de procesos.",
                Descripcion = null
            },
        };

        static RolesStore()
        {
            // Al iniciar, la descripción actual es igual a la descripción por defecto
            foreach (var r in _roles.Values)
                r.Descripcion ??= r.DescripcionDefault;
        }

        // Devuelve todos los nombres de rol (útil para autocompletar)
        public static string[] GetAllNames() => _roles.Values.Select(r => r.Nombre).OrderBy(n => n).ToArray();

        // Obtiene el rol si existe; si no existe y allowCreate=true, lo crea con descripciones vacías
        public static RolInfo GetOrCreate(string nombre, bool allowCreate)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return null;
            if (_roles.TryGetValue(nombre, out var info)) return info;

            if (!allowCreate) return null;

            var nuevo = new RolInfo
            {
                Nombre = nombre.Trim(),
                DescripcionDefault = "Sin descripción por defecto. Documentar responsabilidades y restricciones.",
                Descripcion = "Sin descripción por defecto. Documentar responsabilidades y restricciones."
            };
            _roles[nombre] = nuevo;
            return nuevo;
        }

        // Obtiene rol solo si existe
        public static RolInfo Get(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return null;
            _roles.TryGetValue(nombre, out var info);
            return info;
        }

        // Actualiza la descripción del rol (crea el rol si no existía)
        public static bool UpdateDescription(string nombre, string nuevaDescripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            var info = GetOrCreate(nombre, allowCreate: true);
            info.Descripcion = nuevaDescripcion ?? "";
            return true;
        }

        // Restablece la descripción del rol a su valor por defecto (si no existe, no hace nada)
        public static bool ResetDescription(string nombre)
        {
            var info = Get(nombre);
            if (info == null) return false;
            info.Descripcion = info.DescripcionDefault ?? "";
            return true;
        }
    }
}

