using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;  // ✅ La librería recomendada en .NET 8
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class NEGEmpleados
    {
        private DATEmpleados objetoCD = new DATEmpleados();

        // Ver empleados
        public DataTable View()
        {
            return objetoCD.SelectEmpleados();
        }

        // Crear nuevo empleado
        public void Create(
            string strNombre,
            long NumDocumento,
            string StrDireccion,
            string StrTelefono,
            string StrEmail,
            string NombreRol,
            string StrUsuarioModifico)
        {
            objetoCD.InsertEmpleado(
                strNombre,
                NumDocumento,
                StrDireccion,
                StrTelefono,
                StrEmail,
                NombreRol,
                StrUsuarioModifico
            );
        }

        // Actualizar empleado existente
        public void Update(
            int IdEmpleado,
            string StrNombre,
            long NumDocumento,
            string StrTelefono,
            string StrEmail,
            string StrDireccion,
            string NombreRol,
            string StrUsuarioModifico)
        {
            objetoCD.UpdateEmpleado(
                IdEmpleado,
                StrNombre,
                NumDocumento,
                StrTelefono,
                StrEmail,
                StrDireccion,
                NombreRol,
                StrUsuarioModifico
            );
        }

        // Eliminar (lógico) empleado
        public void Delete(int IdEmpleado, string StrUsuarioModifico)
        {
            objetoCD.DeleteEmpleado(IdEmpleado, StrUsuarioModifico);
        }
    }
}