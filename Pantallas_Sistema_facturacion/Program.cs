using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using Pantallas_Sistema_facturacion.Seguridad;

namespace Pantallas_Sistema_facturacion;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        // Application.Run(new FrmLogin());
        Application.Run(new frmPrincipal());
    }
}