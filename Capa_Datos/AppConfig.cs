using Microsoft.Extensions.Configuration;
using System;
using System.IO;

public static class AppConfig
{
    public static readonly string ConnString;

    static AppConfig()
    {
        try
        {
            var basePath = AppContext.BaseDirectory;
            var cfg = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile(Path.Combine("Config", "appsettings.json"), optional: true, reloadOnChange: true)
                .Build();

            ConnString = cfg.GetConnectionString("AzureSql");
            if (string.IsNullOrWhiteSpace(ConnString))
            {
                var p1 = Path.Combine(basePath, "appsettings.json");
                var p2 = Path.Combine(basePath, "Config", "appsettings.json");
                throw new InvalidOperationException(
                    "No se encontró la cadena 'ConnectionStrings:AzureSql'. " +
                    "Revisa que el JSON exista y se copie al output.\nBuscado en:\n - " + p1 + "\n - " + p2);
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Error inicializando AppConfig: " + ex.Message, ex);
        }
    }
}
