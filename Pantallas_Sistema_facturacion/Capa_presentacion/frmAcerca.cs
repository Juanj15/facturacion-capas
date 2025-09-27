using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void frmAcerca_Load(object sender, EventArgs e)
        {
            // Limpiar texto
            richTextBox1.Clear();

            // ----------- TÍTULO -----------
            richTextBox1.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.DarkGreen;
            richTextBox1.AppendText("📌 Sistema de Facturación\n\n");

            // ----------- VERSIÓN -----------
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("Versión: ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.DarkBlue;
            richTextBox1.AppendText("8.25.1\n");

            // ----------- FECHA -----------
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("Fecha: ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Italic);
            richTextBox1.SelectionColor = Color.DarkRed;
            richTextBox1.AppendText("Agosto 2025\n\n");

            // ----------- AUTOR -----------
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("Autor: ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.DarkBlue;
            richTextBox1.AppendText("Grupo 7\n\n");

            // ----------- DESCRIPCIÓN GENERAL -----------
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText(
                "Este sistema de facturación ha sido desarrollado para optimizar la gestión administrativa " +
                "de pequeñas y medianas empresas. Su objetivo principal es simplificar el manejo de ventas, " +
                "clientes y reportes financieros de manera rápida, segura y organizada.\n\n"
            );

            // ----------- FUNCIONES PRINCIPALES -----------
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold | FontStyle.Underline);
            richTextBox1.SelectionColor = Color.DarkSlateBlue;
            richTextBox1.AppendText("Funciones principales:\n\n");

            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("✔️ Registro de clientes y gestión de información.\n");
            richTextBox1.AppendText("✔️ Creación, edición y control de facturas.\n");
            richTextBox1.AppendText("✔️ Generación de reportes de ventas e informes estadísticos.\n");
            richTextBox1.AppendText("✔️ Panel de ayuda integrado con soporte en línea.\n");
            richTextBox1.AppendText("✔️ Interfaz amigable con diseño moderno.\n\n");

            // ----------- AGRADECIMIENTO FINAL -----------
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Italic);
            richTextBox1.SelectionColor = Color.Gray;
            richTextBox1.AppendText("Gracias por utilizar nuestro sistema. 🚀");

           
        }
    }
}
