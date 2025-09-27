using Capa_Negocio;
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
    public partial class Form1 : Form
    {
        BLLEmpleados objetoCN = new BLLEmpleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Validación de controles
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return;
                }
                if (txtDocumento.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDocumento.Focus();
                    return;
                }
                if (txtTelefono.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                    return;
                }
                if (txtCorreo.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nro de Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreo.Focus();
                    return;
                }
                if (txtDireccion.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nivel de Seguridad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();
                    return;
                }

                objetoCN.Create(txtNombre.Text, Convert.ToInt32(txtDocumento.Text), txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, 1, DateTime.Now, DateTime.Now, "prueba", DateTime.Now, "prueba usuario", Convert.ToBoolean(1));
                MessageBox.Show("Se guardo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos, se encontro el siguiente error : " + ex);
            }
        }
    }
}
