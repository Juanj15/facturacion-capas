namespace Pantallas_Sistema_facturacion.Seguridad
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Recursos del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Inicializa los controles del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtBuscarEmpleados = new MaterialSkin.Controls.MaterialTextBox2();
            btnBuscarEmpleados = new MaterialSkin.Controls.MaterialButton();
            dgvEmpleados = new DataGridView();
            btnNuevoEmpleado = new MaterialSkin.Controls.MaterialButton();
            IdEmpleado = new DataGridViewTextBoxColumn();
            CLIENTE = new DataGridViewTextBoxColumn();
            DOCUMENTO = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            CORREO = new DataGridViewTextBoxColumn();
            DIRECCIÓN = new DataGridViewTextBoxColumn();
            ROL = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewButtonColumn();
            colBorrar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(522, 60);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(248, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "ADMINISTRADOR DE EMPLEADOS";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // txtBuscarEmpleados
            // 
            txtBuscarEmpleados.AnimateReadOnly = false;
            txtBuscarEmpleados.BackgroundImageLayout = ImageLayout.None;
            txtBuscarEmpleados.CharacterCasing = CharacterCasing.Normal;
            txtBuscarEmpleados.Depth = 0;
            txtBuscarEmpleados.Font = new Font("Segoe UI", 10.2F);
            txtBuscarEmpleados.HideSelection = true;
            txtBuscarEmpleados.LeadingIcon = null;
            txtBuscarEmpleados.Location = new Point(55, 132);
            txtBuscarEmpleados.MaxLength = 32767;
            txtBuscarEmpleados.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarEmpleados.Name = "txtBuscarEmpleados";
            txtBuscarEmpleados.PasswordChar = '\0';
            txtBuscarEmpleados.PrefixSuffixText = null;
            txtBuscarEmpleados.ReadOnly = false;
            txtBuscarEmpleados.RightToLeft = RightToLeft.No;
            txtBuscarEmpleados.SelectedText = "";
            txtBuscarEmpleados.SelectionLength = 0;
            txtBuscarEmpleados.SelectionStart = 0;
            txtBuscarEmpleados.ShortcutsEnabled = true;
            txtBuscarEmpleados.Size = new Size(488, 48);
            txtBuscarEmpleados.TabIndex = 1;
            txtBuscarEmpleados.TabStop = false;
            txtBuscarEmpleados.Text = "Buscar empleado";
            txtBuscarEmpleados.TextAlign = HorizontalAlignment.Left;
            txtBuscarEmpleados.TrailingIcon = null;
            txtBuscarEmpleados.UseSystemPasswordChar = false;
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarEmpleados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarEmpleados.Depth = 0;
            btnBuscarEmpleados.HighEmphasis = true;
            btnBuscarEmpleados.Icon = null;
            btnBuscarEmpleados.Location = new Point(561, 144);
            btnBuscarEmpleados.Margin = new Padding(4, 6, 4, 6);
            btnBuscarEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.NoAccentTextColor = Color.Empty;
            btnBuscarEmpleados.Size = new Size(77, 36);
            btnBuscarEmpleados.TabIndex = 2;
            btnBuscarEmpleados.Text = "Buscar";
            btnBuscarEmpleados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarEmpleados.UseAccentColor = false;
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.Control;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { IdEmpleado, CLIENTE, DOCUMENTO, TELEFONO, CORREO, DIRECCIÓN, ROL, colEditar, colBorrar });
            dgvEmpleados.Location = new Point(55, 209);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1188, 282);
            dgvEmpleados.TabIndex = 3;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNuevoEmpleado.Depth = 0;
            btnNuevoEmpleado.HighEmphasis = true;
            btnNuevoEmpleado.Icon = null;
            btnNuevoEmpleado.Location = new Point(984, 144);
            btnNuevoEmpleado.Margin = new Padding(4, 6, 4, 6);
            btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.NoAccentTextColor = Color.Empty;
            btnNuevoEmpleado.Size = new Size(168, 36);
            btnNuevoEmpleado.TabIndex = 4;
            btnNuevoEmpleado.Text = "Agregar empleado";
            btnNuevoEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNuevoEmpleado.UseAccentColor = false;
            btnNuevoEmpleado.UseVisualStyleBackColor = true;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // IdEmpleado
            // 
            IdEmpleado.DataPropertyName = "IdEmpleado";
            IdEmpleado.HeaderText = "ID";
            IdEmpleado.MinimumWidth = 6;
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.Width = 80;
            // 
            // CLIENTE
            // 
            CLIENTE.DataPropertyName = "strNombre";
            CLIENTE.HeaderText = "NOMBRE";
            CLIENTE.MinimumWidth = 6;
            CLIENTE.Name = "CLIENTE";
            CLIENTE.Width = 200;
            // 
            // DOCUMENTO
            // 
            DOCUMENTO.DataPropertyName = "NumDocumento";
            DOCUMENTO.HeaderText = "DOCUMENTO";
            DOCUMENTO.MinimumWidth = 6;
            DOCUMENTO.Name = "DOCUMENTO";
            DOCUMENTO.Width = 150;
            // 
            // TELEFONO
            // 
            TELEFONO.DataPropertyName = "StrTelefono";
            TELEFONO.HeaderText = "TELÉFONO";
            TELEFONO.MinimumWidth = 6;
            TELEFONO.Name = "TELEFONO";
            TELEFONO.Width = 150;
            // 
            // CORREO
            // 
            CORREO.DataPropertyName = "StrEmail";
            CORREO.HeaderText = "CORREO";
            CORREO.MinimumWidth = 6;
            CORREO.Name = "CORREO";
            CORREO.Width = 125;
            // 
            // DIRECCIÓN
            // 
            DIRECCIÓN.DataPropertyName = "StrDireccion";
            DIRECCIÓN.HeaderText = "DIRECCIÓN";
            DIRECCIÓN.MinimumWidth = 6;
            DIRECCIÓN.Name = "DIRECCIÓN";
            DIRECCIÓN.Width = 125;
            // 
            // ROL
            // 
            ROL.DataPropertyName = "IdRolEmpleado";
            ROL.HeaderText = "ROL";
            ROL.MinimumWidth = 6;
            ROL.Name = "ROL";
            ROL.Width = 125;
            // 
            // colEditar
            // 
            colEditar.HeaderText = "EDITAR";
            colEditar.MinimumWidth = 6;
            colEditar.Name = "colEditar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Width = 90;
            // 
            // colBorrar
            // 
            colBorrar.HeaderText = "BORRAR";
            colBorrar.MinimumWidth = 6;
            colBorrar.Name = "colBorrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            colBorrar.Width = 90;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 607);
            Controls.Add(btnNuevoEmpleado);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnBuscarEmpleados);
            Controls.Add(txtBuscarEmpleados);
            Controls.Add(materialLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscarEmpleados;
        private MaterialSkin.Controls.MaterialButton btnBuscarEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private MaterialSkin.Controls.MaterialButton btnNuevoEmpleado;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn CLIENTE;
        private DataGridViewTextBoxColumn DOCUMENTO;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn CORREO;
        private DataGridViewTextBoxColumn DIRECCIÓN;
        private DataGridViewTextBoxColumn ROL;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colBorrar;
    }
}
