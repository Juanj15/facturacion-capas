using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;


namespace Pantallas_Sistema_facturacion
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private async void frmAyuda_Load(object sender, EventArgs e)
        {
            // Inicializa WebView2 (obligatorio la primera vez)
            await webView21.EnsureCoreWebView2Async(null);

            // Carga la página de ayuda
            webView21.Source = new Uri("https://support.microsoft.com/es-es");
        }

      
    }
}
