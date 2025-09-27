namespace Pantallas_Sistema_facturacion.Seguridad
{
    partial class FrmEmpleadoEdit
    {
        /// <summary>
        /// Componentes del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberación de recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código del Diseñador

        /// <summary>
        /// Inicializa y configura los controles del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            txtDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox2();
            cboRol = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(218, 23);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "INGRESA LOS DATOS";
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HideSelection = true;
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(161, 84);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = false;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(273, 48);
            txtNombre.TabIndex = 1;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.Click += txtNombre_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.AnimateReadOnly = false;
            txtDocumento.BackgroundImageLayout = ImageLayout.None;
            txtDocumento.CharacterCasing = CharacterCasing.Normal;
            txtDocumento.Depth = 0;
            txtDocumento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocumento.HideSelection = true;
            txtDocumento.LeadingIcon = null;
            txtDocumento.Location = new Point(161, 151);
            txtDocumento.Margin = new Padding(3, 2, 3, 2);
            txtDocumento.MaxLength = 32767;
            txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PasswordChar = '\0';
            txtDocumento.PrefixSuffixText = null;
            txtDocumento.ReadOnly = false;
            txtDocumento.RightToLeft = RightToLeft.No;
            txtDocumento.SelectedText = "";
            txtDocumento.SelectionLength = 0;
            txtDocumento.SelectionStart = 0;
            txtDocumento.ShortcutsEnabled = true;
            txtDocumento.Size = new Size(273, 48);
            txtDocumento.TabIndex = 2;
            txtDocumento.TabStop = false;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.TrailingIcon = null;
            txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.CharacterCasing = CharacterCasing.Normal;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HideSelection = true;
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(161, 220);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.ReadOnly = false;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(273, 48);
            txtTelefono.TabIndex = 3;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(204, 493);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(314, 493);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(161, 68);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(127, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Nombre completo";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(161, 134);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(83, 19);
            materialLabel2.TabIndex = 7;
            materialLabel2.Text = "Documento";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(161, 203);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(64, 19);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Teléfono";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(161, 272);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(128, 19);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.AnimateReadOnly = false;
            txtCorreo.BackgroundImageLayout = ImageLayout.None;
            txtCorreo.CharacterCasing = CharacterCasing.Normal;
            txtCorreo.Depth = 0;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.HideSelection = true;
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(161, 289);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.PrefixSuffixText = null;
            txtCorreo.ReadOnly = false;
            txtCorreo.RightToLeft = RightToLeft.No;
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.ShortcutsEnabled = true;
            txtCorreo.Size = new Size(273, 48);
            txtCorreo.TabIndex = 10;
            txtCorreo.TabStop = false;
            txtCorreo.TextAlign = HorizontalAlignment.Left;
            txtCorreo.TrailingIcon = null;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(161, 340);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(67, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.BackgroundImageLayout = ImageLayout.None;
            txtDireccion.CharacterCasing = CharacterCasing.Normal;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.HideSelection = true;
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(161, 357);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.MaxLength = 32767;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PasswordChar = '\0';
            txtDireccion.PrefixSuffixText = null;
            txtDireccion.ReadOnly = false;
            txtDireccion.RightToLeft = RightToLeft.No;
            txtDireccion.SelectedText = "";
            txtDireccion.SelectionLength = 0;
            txtDireccion.SelectionStart = 0;
            txtDireccion.ShortcutsEnabled = true;
            txtDireccion.Size = new Size(273, 48);
            txtDireccion.TabIndex = 12;
            txtDireccion.TabStop = false;
            txtDireccion.TextAlign = HorizontalAlignment.Left;
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseSystemPasswordChar = false;
            // 
            // cboRol
            // 
            cboRol.AutoResize = false;
            cboRol.BackColor = Color.FromArgb(255, 255, 255);
            cboRol.Depth = 0;
            cboRol.DrawMode = DrawMode.OwnerDrawVariable;
            cboRol.DropDownHeight = 174;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.DropDownWidth = 121;
            cboRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboRol.FormattingEnabled = true;
            cboRol.IntegralHeight = false;
            cboRol.ItemHeight = 43;
            cboRol.Items.AddRange(new object[] { "Gerente", "Secretaría", "Operario", "Administrativo" });
            cboRol.Location = new Point(161, 425);
            cboRol.Margin = new Padding(3, 2, 3, 2);
            cboRol.MaxDropDownItems = 4;
            cboRol.MouseState = MaterialSkin.MouseState.OUT;
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(133, 49);
            cboRol.StartIndex = 0;
            cboRol.TabIndex = 13;
            cboRol.SelectedIndexChanged += cboRol_SelectedIndexChanged;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(161, 409);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(24, 19);
            materialLabel6.TabIndex = 14;
            materialLabel6.Text = "Rol";
            // 
            // FrmEmpleadoEdit
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(615, 554);
            Controls.Add(materialLabel6);
            Controls.Add(cboRol);
            Controls.Add(txtDireccion);
            Controls.Add(materialLabel5);
            Controls.Add(txtCorreo);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEmpleadoEdit";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtDocumento;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccion;
        private MaterialSkin.Controls.MaterialComboBox cboRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}
