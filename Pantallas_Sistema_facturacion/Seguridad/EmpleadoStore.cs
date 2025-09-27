using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public static class EmpleadoStore
    {
        private static int _nextId = 1;

        public static BindingList<Empleado> Empleados { get; } = new BindingList<Empleado>
        {
            new Empleado { Id = _nextId++, Nombre = "Ana Torres",      Documento = "1002003001", Telefono = "3001234567", Correo = "ana.torres@cli.com" },
            new Empleado { Id = _nextId++, Nombre = "Luis Pérez",      Documento = "1002003002", Telefono = "3109876543", Correo = "ana.torres@cli.com" },
            new Empleado { Id = _nextId++, Nombre = "María Gómez",     Documento = "1002003003", Telefono = "3155558899", Correo = "ana.torres@cli.com" },
            new Empleado { Id = _nextId++, Nombre = "Carlos Ramírez",  Documento = "1002003004", Telefono = "3012233445", Correo = "ana.torres@cli.com" },
            new Empleado { Id = _nextId++, Nombre = "Sofía Herrera",   Documento = "1002003005", Telefono = "3026677889", Correo = "ana.torres@cli.com" },
            new Empleado { Id = _nextId++, Nombre = "Julián Rojas",    Documento = "1002003006", Telefono = "3041122334", Correo = "ana.torres@cli.com" },
            new Empleado { Id = _nextId++, Nombre = "Valentina Ruiz",  Documento = "1002003007", Telefono = "3117788990", Correo = "ana.torres@cli.com" },
            new Empleado { Id = _nextId++, Nombre = "Andrés Castillo", Documento = "1002003008", Telefono = "3123344556", Correo = "ana.torres@cli.com" },
        };

        public static Empleado Add(string nombre, string documento, string telefono, string correo, string direccion, int? idRolEmpleado, string? nombreRol = null)
        {
            var e = new Empleado { Id = _nextId++, Nombre = nombre, Documento = documento, Telefono = telefono, Correo = correo, Direccion = direccion, IdRolEmpleado = idRolEmpleado, NombreRol = nombreRol ?? string.Empty };
            Empleados.Add(e);
            return e;
        }

        public static List<Empleado> SearchByNombre(string? term)
        {
            if (string.IsNullOrWhiteSpace(term)) return Empleados.ToList();
            return Empleados
                .Where(e => e.Nombre.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public static bool RemoveById(int id)
        {
            var emp = Empleados.FirstOrDefault(x => x.Id == id);
            if (emp == null) return false;
            Empleados.Remove(emp);
            return true;
        }
    }
}
