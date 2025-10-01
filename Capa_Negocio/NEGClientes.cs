using Capa_Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NEGClientes
    {
        // Instancia de la capa de datos
        private readonly DATClientes objetoCD = new DATClientes();

        /// <summary>
        /// Obtiene todos los clientes activos desde la base de datos.
        /// </summary>
        /// <returns>DataTable con los clientes activos.</returns>
        public DataTable View()
        {
            return objetoCD.SelectClientesActivos();
        }

        /// <summary>
        /// Crea un nuevo cliente en la base de datos.
        /// </summary>
        /// <param name="strNombre">Nombre del cliente</param>
        /// <param name="NumDocumento">Número de documento</param>
        /// <param name="StrDireccion">Dirección</param>
        /// <param name="StrTelefono">Teléfono</param>
        /// <param name="StrEmail">Correo electrónico</param>
        /// <param name="StrUsuarioModifica">Usuario que realiza la inserción</param>
        public void Create(
            string strNombre,
            long NumDocumento,
            string StrDireccion,
            string StrTelefono,
            string StrEmail,
            string StrUsuarioModifica)
        {
            objetoCD.InsertCliente(
                strNombre,
                NumDocumento,
                StrDireccion,
                StrTelefono,
                StrEmail,
                StrUsuarioModifica
            );
        }

        /// <summary>
        /// Actualiza los datos de un cliente existente.
        /// </summary>
        /// <param name="IdCliente">Id del cliente a actualizar</param>
        /// <param name="StrNombre">Nombre del cliente</param>
        /// <param name="NumDocumento">Número de documento</param>
        /// <param name="StrTelefono">Teléfono</param>
        /// <param name="StrEmail">Correo electrónico</param>
        /// <param name="StrDireccion">Dirección</param>
        /// <param name="StrUsuarioModifica">Usuario que realiza la actualización</param>
        public void Update(
            int IdCliente,
            string StrNombre,
            long NumDocumento,
            string StrTelefono,
            string StrEmail,
            string StrDireccion,
            string StrUsuarioModifica)
        {
            objetoCD.UpdateCliente(
                IdCliente,
                StrNombre,
                NumDocumento,
                StrTelefono,
                StrEmail,
                StrDireccion,
                StrUsuarioModifica
            );
        }

        /// <summary>
        /// Marca un cliente como inactivo (eliminación lógica).
        /// </summary>
        /// <param name="IdCliente">Id del cliente a eliminar</param>
        /// <param name="StrUsuarioModifica">Usuario que realiza la eliminación</param>
        public void Delete(int IdCliente, string StrUsuarioModifica)
        {
            objetoCD.DeleteCliente(IdCliente, StrUsuarioModifica);
        }
    }
}
