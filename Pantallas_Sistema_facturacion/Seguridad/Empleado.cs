using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Documento { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Direccion { get; set; } = "";
        public int? IdRolEmpleado { get; set; }
        public string NombreRol { get; set; } = "";

        public bool Activo { get; set; } = true;
    }
}
