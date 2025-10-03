using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Documento { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Direccion { get; set; } = "";
        public int? IdRolEmpleado { get; set; }
        public string NombreRol { get; set; } = "";
    }
}
