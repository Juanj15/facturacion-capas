namespace Pantallas_Sistema_facturacion.Seguridad
{
    partial class frmRoles
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            lblNombreRol = new MaterialSkin.Controls.MaterialLabel();
            pnlRolNombre = new Panel();
            txtRolNombre = new TextBox();
            pnlUnderlineRolNombre = new Panel();
            lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            txtRolDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btnRolActualizar = new MaterialSkin.Controls.MaterialButton();
            btnRolCancelar = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pnlRolNombre.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo.Location = new Point(530, 52);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ROLES DE LOS EMPLEADOS";
            // 
            // lblNombreRol
            // 
            lblNombreRol.AutoSize = true;
            lblNombreRol.Depth = 0;
            lblNombreRol.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombreRol.Location = new Point(325, 115);
            lblNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreRol.Name = "lblNombreRol";
            lblNombreRol.Size = new Size(104, 19);
            lblNombreRol.TabIndex = 1;
            lblNombreRol.Text = "Nombre del rol";
            // 
            // pnlRolNombre
            // 
            pnlRolNombre.BackColor = Color.Transparent;
            pnlRolNombre.Controls.Add(txtRolNombre);
            pnlRolNombre.Controls.Add(pnlUnderlineRolNombre);
            pnlRolNombre.Location = new Point(325, 134);
            pnlRolNombre.Name = "pnlRolNombre";
            pnlRolNombre.Padding = new Padding(8, 8, 8, 0);
            pnlRolNombre.Size = new Size(435, 42);
            pnlRolNombre.TabIndex = 2;
            // 
            // txtRolNombre
            // 
            txtRolNombre.BackColor = Color.White;
            txtRolNombre.BorderStyle = BorderStyle.None;
            txtRolNombre.Font = new Font("Segoe UI", 10.2F);
            txtRolNombre.ForeColor = Color.Black;
            txtRolNombre.Location = new Point(10, 12);
            txtRolNombre.Name = "txtRolNombre";
            txtRolNombre.Size = new Size(415, 23);
            txtRolNombre.TabIndex = 0;
            // 
            // pnlUnderlineRolNombre
            // 
            pnlUnderlineRolNombre.BackColor = Color.Silver;
            pnlUnderlineRolNombre.Dock = DockStyle.Bottom;
            pnlUnderlineRolNombre.Location = new Point(8, 40);
            pnlUnderlineRolNombre.Name = "pnlUnderlineRolNombre";
            pnlUnderlineRolNombre.Size = new Size(419, 2);
            pnlUnderlineRolNombre.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Depth = 0;
            lblDescripcion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDescripcion.Location = new Point(325, 192);
            lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(201, 19);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción detallada del rol";
            // 
            // txtRolDescripcion
            // 
            txtRolDescripcion.AnimateReadOnly = false;
            txtRolDescripcion.BackgroundImageLayout = ImageLayout.None;
            txtRolDescripcion.CharacterCasing = CharacterCasing.Normal;
            txtRolDescripcion.Depth = 0;
            txtRolDescripcion.HideSelection = true;
            txtRolDescripcion.Location = new Point(325, 214);
            txtRolDescripcion.MaxLength = 32767;
            txtRolDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            txtRolDescripcion.Name = "txtRolDescripcion";
            txtRolDescripcion.PasswordChar = '\0';
            txtRolDescripcion.ReadOnly = true;
            txtRolDescripcion.ScrollBars = ScrollBars.None;
            txtRolDescripcion.SelectedText = "";
            txtRolDescripcion.SelectionLength = 0;
            txtRolDescripcion.SelectionStart = 0;
            txtRolDescripcion.ShortcutsEnabled = true;
            txtRolDescripcion.Size = new Size(624, 209);
            txtRolDescripcion.TabIndex = 4;
            txtRolDescripcion.TabStop = false;
            txtRolDescripcion.TextAlign = HorizontalAlignment.Left;
            txtRolDescripcion.UseSystemPasswordChar = false;
            // 
            // btnRolActualizar
            // 
            btnRolActualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRolActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRolActualizar.Depth = 0;
            btnRolActualizar.Enabled = false;
            btnRolActualizar.HighEmphasis = true;
            btnRolActualizar.Icon = null;
            btnRolActualizar.Location = new Point(503, 458);
            btnRolActualizar.Margin = new Padding(4, 6, 4, 6);
            btnRolActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            btnRolActualizar.Name = "btnRolActualizar";
            btnRolActualizar.NoAccentTextColor = Color.Empty;
            btnRolActualizar.Size = new Size(109, 36);
            btnRolActualizar.TabIndex = 5;
            btnRolActualizar.Text = "ACTUALIZAR";
            btnRolActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRolActualizar.UseAccentColor = false;
            btnRolActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRolCancelar
            // 
            btnRolCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRolCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRolCancelar.Depth = 0;
            btnRolCancelar.Enabled = false;
            btnRolCancelar.HighEmphasis = true;
            btnRolCancelar.Icon = null;
            btnRolCancelar.Location = new Point(658, 458);
            btnRolCancelar.Margin = new Padding(4, 6, 4, 6);
            btnRolCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnRolCancelar.Name = "btnRolCancelar";
            btnRolCancelar.NoAccentTextColor = Color.Empty;
            btnRolCancelar.Size = new Size(96, 36);
            btnRolCancelar.TabIndex = 6;
            btnRolCancelar.Text = "CANCELAR";
            btnRolCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRolCancelar.UseAccentColor = false;
            btnRolCancelar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialLabel1.Location = new Point(974, 214);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(161, 110);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Roles disponibles:\r\n\r\n* Gerente\r\n* Secretaría\r\n* Operario\r\n* Administrativo";
            // 
            // frmRoles
            // 
            AcceptButton = btnRolActualizar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnRolCancelar;
            ClientSize = new Size(1300, 548);
            Controls.Add(materialLabel1);
            Controls.Add(btnRolCancelar);
            Controls.Add(btnRolActualizar);
            Controls.Add(txtRolDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(pnlRolNombre);
            Controls.Add(lblNombreRol);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRoles";
            Text = "frmRoles";
            pnlRolNombre.ResumeLayout(false);
            pnlRolNombre.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblNombreRol;
        private System.Windows.Forms.Panel pnlRolNombre;
        private System.Windows.Forms.TextBox txtRolNombre;
        private System.Windows.Forms.Panel pnlUnderlineRolNombre;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtRolDescripcion;
        private MaterialSkin.Controls.MaterialButton btnRolActualizar;
        private MaterialSkin.Controls.MaterialButton btnRolCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
