using System;
using System.Data;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Capa_Datos
{
    public class DATConexion
    {
        private readonly SqlConnection Conexion;

        public DATConexion()
        {
            // Construye la configuración para leer el appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Ruta base de la app
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // Obtiene la cadena de conexión llamada "AzureSql"
            string connectionString = configuration.GetConnectionString("AzureSql");

            // Inicializa la conexión
            Conexion = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}