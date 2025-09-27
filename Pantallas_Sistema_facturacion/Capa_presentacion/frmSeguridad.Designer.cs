namespace Pantallas_Sistema_facturacion.Seguridad
{
    partial class frmSeguridad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            pnlEmpleado = new Panel();
            txtSegEmpleado = new TextBox();
            pnlUnderlineEmpleado = new Panel();
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            txtSegUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            lblClave = new MaterialSkin.Controls.MaterialLabel();
            txtSegClave = new MaterialSkin.Controls.MaterialTextBox2();
            btnSegActualizar = new MaterialSkin.Controls.MaterialButton();
            btnSegCancelar = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pnlEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo.Location = new Point(504, 49);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ASIGNACIÓN DE CREDENCIALES";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Depth = 0;
            lblEmpleado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEmpleado.Location = new Point(374, 109);
            lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(124, 19);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Buscar empleado";
            // 
            // pnlEmpleado
            // 
            pnlEmpleado.BackColor = Color.Transparent;
            pnlEmpleado.Controls.Add(txtSegEmpleado);
            pnlEmpleado.Controls.Add(pnlUnderlineEmpleado);
            pnlEmpleado.Location = new Point(374, 129);
            pnlEmpleado.Name = "pnlEmpleado";
            pnlEmpleado.Padding = new Padding(8, 8, 8, 0);
            pnlEmpleado.Size = new Size(480, 42);
            pnlEmpleado.TabIndex = 2;
            // 
            // txtSegEmpleado
            // 
            txtSegEmpleado.BackColor = Color.White;
            txtSegEmpleado.BorderStyle = BorderStyle.None;
            txtSegEmpleado.Font = new Font("Segoe UI", 10.2F);
            txtSegEmpleado.ForeColor = Color.Black;
            txtSegEmpleado.Location = new Point(10, 12);
            txtSegEmpleado.Name = "txtSegEmpleado";
            txtSegEmpleado.Size = new Size(460, 23);
            txtSegEmpleado.TabIndex = 0;
            // 
            // pnlUnderlineEmpleado
            // 
            pnlUnderlineEmpleado.BackColor = Color.Silver;
            pnlUnderlineEmpleado.Dock = DockStyle.Bottom;
            pnlUnderlineEmpleado.Location = new Point(8, 40);
            pnlUnderlineEmpleado.Name = "pnlUnderlineEmpleado";
            pnlUnderlineEmpleado.Size = new Size(464, 2);
            pnlUnderlineEmpleado.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsuario.Location = new Point(374, 256);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(55, 19);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // txtSegUsuario
            // 
            txtSegUsuario.AnimateReadOnly = false;
            txtSegUsuario.BackgroundImageLayout = ImageLayout.None;
            txtSegUsuario.CharacterCasing = CharacterCasing.Normal;
            txtSegUsuario.Depth = 0;
            txtSegUsuario.Font = new Font("Segoe UI", 10.2F);
            txtSegUsuario.HideSelection = true;
            txtSegUsuario.LeadingIcon = null;
            txtSegUsuario.Location = new Point(374, 276);
            txtSegUsuario.MaxLength = 100;
            txtSegUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtSegUsuario.Name = "txtSegUsuario";
            txtSegUsuario.PasswordChar = '\0';
            txtSegUsuario.PrefixSuffixText = null;
            txtSegUsuario.ReadOnly = true;
            txtSegUsuario.RightToLeft = RightToLeft.No;
            txtSegUsuario.SelectedText = "";
            txtSegUsuario.SelectionLength = 0;
            txtSegUsuario.SelectionStart = 0;
            txtSegUsuario.ShortcutsEnabled = true;
            txtSegUsuario.Size = new Size(480, 48);
            txtSegUsuario.TabIndex = 1;
            txtSegUsuario.TabStop = false;
            txtSegUsuario.TextAlign = HorizontalAlignment.Left;
            txtSegUsuario.TrailingIcon = null;
            txtSegUsuario.UseSystemPasswordChar = false;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Depth = 0;
            lblClave.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblClave.Location = new Point(374, 341);
            lblClave.MouseState = MaterialSkin.MouseState.HOVER;
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(82, 19);
            lblClave.TabIndex = 5;
            lblClave.Text = "Contraseña";
            // 
            // txtSegClave
            // 
            txtSegClave.AnimateReadOnly = false;
            txtSegClave.BackgroundImageLayout = ImageLayout.None;
            txtSegClave.CharacterCasing = CharacterCasing.Normal;
            txtSegClave.Depth = 0;
            txtSegClave.Font = new Font("Segoe UI", 10.2F);
            txtSegClave.HideSelection = true;
            txtSegClave.LeadingIcon = null;
            txtSegClave.Location = new Point(374, 361);
            txtSegClave.MaxLength = 100;
            txtSegClave.MouseState = MaterialSkin.MouseState.OUT;
            txtSegClave.Name = "txtSegClave";
            txtSegClave.PasswordChar = '●';
            txtSegClave.PrefixSuffixText = null;
            txtSegClave.ReadOnly = true;
            txtSegClave.RightToLeft = RightToLeft.No;
            txtSegClave.SelectedText = "";
            txtSegClave.SelectionLength = 0;
            txtSegClave.SelectionStart = 0;
            txtSegClave.ShortcutsEnabled = true;
            txtSegClave.Size = new Size(480, 48);
            txtSegClave.TabIndex = 2;
            txtSegClave.TabStop = false;
            txtSegClave.TextAlign = HorizontalAlignment.Left;
            txtSegClave.TrailingIcon = null;
            txtSegClave.UseSystemPasswordChar = true;
            // 
            // btnSegActualizar
            // 
            btnSegActualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSegActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSegActualizar.Depth = 0;
            btnSegActualizar.Enabled = false;
            btnSegActualizar.HighEmphasis = true;
            btnSegActualizar.Icon = null;
            btnSegActualizar.Location = new Point(479, 441);
            btnSegActualizar.Margin = new Padding(4, 6, 4, 6);
            btnSegActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSegActualizar.Name = "btnSegActualizar";
            btnSegActualizar.NoAccentTextColor = Color.Empty;
            btnSegActualizar.Size = new Size(109, 36);
            btnSegActualizar.TabIndex = 3;
            btnSegActualizar.Text = "ACTUALIZAR";
            btnSegActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSegActualizar.UseAccentColor = false;
            btnSegActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSegCancelar
            // 
            btnSegCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSegCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSegCancelar.Depth = 0;
            btnSegCancelar.Enabled = false;
            btnSegCancelar.HighEmphasis = true;
            btnSegCancelar.Icon = null;
            btnSegCancelar.Location = new Point(634, 441);
            btnSegCancelar.Margin = new Padding(4, 6, 4, 6);
            btnSegCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSegCancelar.Name = "btnSegCancelar";
            btnSegCancelar.NoAccentTextColor = Color.Empty;
            btnSegCancelar.Size = new Size(96, 36);
            btnSegCancelar.TabIndex = 4;
            btnSegCancelar.Text = "CANCELAR";
            btnSegCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSegCancelar.UseAccentColor = false;
            btnSegCancelar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(374, 210);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(368, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Ingresa o modifica la información de este empleado";
            // 
            // frmSeguridad
            // 
            AcceptButton = btnSegActualizar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSegCancelar;
            ClientSize = new Size(1300, 548);
            Controls.Add(materialLabel1);
            Controls.Add(btnSegCancelar);
            Controls.Add(btnSegActualizar);
            Controls.Add(txtSegClave);
            Controls.Add(lblClave);
            Controls.Add(txtSegUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(pnlEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSeguridad";
            Text = "frmSeguridad";
            pnlEmpleado.ResumeLayout(false);
            pnlEmpleado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private System.Windows.Forms.Panel pnlEmpleado;
        private System.Windows.Forms.TextBox txtSegEmpleado;
        private System.Windows.Forms.Panel pnlUnderlineEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegUsuario;
        private MaterialSkin.Controls.MaterialLabel lblClave;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegClave;
        private MaterialSkin.Controls.MaterialButton btnSegActualizar;
        private MaterialSkin.Controls.MaterialButton btnSegCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
