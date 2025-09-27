using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Pantallas_Sistema_facturacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbnValidar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(AppConfig.ConnString))
            {
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT COUNT(*) FROM TBLSEGURIDAD " +
                                        "WHERE StrUsuario = @usuario AND StrClave = @clave ";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@clave", contraseña);

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("✅ Login exitoso. Bienvenido " + usuario);
                                     new frmPrincipal().Show();
                                     this.Hide();
                                 }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.");
                            }
                        }
                    }

                    catch (Exception ex) {

                        MessageBox.Show("Error de conexión: " + ex.Message);
    
                    }

                }
            }
                
        }
    }
}
