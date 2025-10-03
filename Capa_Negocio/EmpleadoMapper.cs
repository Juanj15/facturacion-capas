using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_Negocio
{
    public static class EmpleadoMapper
    {
        public static List<EmpleadoDTO> FromDataTable(DataTable dt)
        {
            var lista = new List<EmpleadoDTO>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new EmpleadoDTO
                {
                    Id = Convert.ToInt32(row["IdEmpleado"]),
                    Nombre = row["Nombre"].ToString(),
                    Documento = row["Documento"].ToString(),
                    Telefono = row["Telefono"].ToString(),
                    Correo = row["Correo"].ToString(),
                    Direccion = row["Direccion"].ToString(),
                    IdRolEmpleado = row["IdRolEmpleado"] == DBNull.Value ? null : (int?)Convert.ToInt32(row["IdRolEmpleado"]),
                    NombreRol = row["NombreRol"].ToString()
                });
            }

            return lista;
        }
    }
}
