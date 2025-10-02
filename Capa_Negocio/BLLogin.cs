using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class BLLogin
    {
        private DALLogin dal = new DALLogin();

        public bool Login(string usuario, string contraseña)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                return false;

            return dal.ValidarLogin(usuario, contraseña);
        }
    }
}