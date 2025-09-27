using Capa_Datos;
using System;
using System.Data;
using Microsoft.Data.SqlClient; // Cambiado de System.Data.SqlClient

namespace Capa_Negocio
{
    public class BLLEmpleados
    {
        private DALEmpleados objetoCD = new DALEmpleados();

        public void Create(string strNombre, int NumDocumento, string StrDireccion, string StrTelefono, string StrEmail, int IdRolEmpleado, DateTime DtmIngreso, DateTime DtmRetiro, string strDatosAdicionales, DateTime DtmFechaModifica, string StrUsuarioModifico, bool Activo)
        {
            objetoCD.CreateEmpleado(strNombre, Convert.ToInt32(NumDocumento), StrDireccion, StrTelefono, StrEmail, Convert.ToInt32(IdRolEmpleado), DtmIngreso, DtmRetiro, strDatosAdicionales, DtmFechaModifica, StrUsuarioModifico, Convert.ToBoolean(Activo));
        }

        public DataTable View()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ReadAllEmpleado();
            return tabla;
        }

        public void Delete(int IdEmpleado)
        {
            objetoCD.DeleteEmpleado(IdEmpleado);
        }


    }
}